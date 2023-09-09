using System;
using System.Collections.Generic;
using System.IO;   //添加命名空间或程序集
using System.Linq;
using System.Security.Cryptography;  //添加命名空间或程序集
using System.Text;
using System.Web.Security;  //添加命名空间或程序集

//MD5加密类，调用的步骤如下：
//1、Comm.MD5Encrypt.MD5Encrypt16(password)
//2、Comm.MD5Encrypt.MD5Encrypt32(password)
//3、Comm.MD5Encrypt.MD5Encrypt64(password)
//4、Comm.MD5Encrypt.md5(password，16)或Comm.MD5Encrypt.md5(password，32)
//5、加密：Comm.MD5Encrypt.Encrypt(password,"pan")/解密：Comm.MD5Encrypt.Decrypt(password,"pan")
//6、加密：Comm.MD5Encrypt.Encrypt2(password)/解密：Comm.MD5Encrypt.Decrypt2(password)
namespace com.vdm.common
{
    public class MD5Encrypt
    {
        //第一种：由于MD5是不可逆的，所以加密之后就无法解密，取用户名和密码时候，
        //需要再加密一边用户输入的数据与数据库中已加密的数据进行比对。如果比对结果一致，则可以判定登陆成功！
        #region  ========（一、）16位MD5加密，无法解密========
        /// <summary>
        /// 16位MD5加密，无法解密
        /// </summary>
        /// <param name="password">密码</param>
        /// <returns>加密后的密码</returns>
        public static string MD5Encrypt16(string password)
        {
            var md5 = new MD5CryptoServiceProvider();
            string t2 = BitConverter.ToString(md5.ComputeHash(Encoding.Default.GetBytes(password)), 4, 8);
            t2 = t2.Replace("-", "");
            return t2;
        }
        #endregion

        #region  ========（二、）32位MD5加密，无法解密========
        /// <summary>
        /// 32位MD5加密，无法解密
        /// </summary>
        /// <param name="password">密码</param>
        /// <returns>加密后的密码</returns>
        public static string MD5Encrypt32(string password)
        {
            string cl = password;
            string pwd = "";
            MD5 md5 = MD5.Create(); //实例化一个md5对像
            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(cl));
            // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            for (int i = 0; i < s.Length; i++)
            {
                // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 
                pwd = pwd + s[i].ToString("X");
            }
            return pwd;
        }
        #endregion

        #region  ========（三、）64位MD5加密，无法解密========
        /// <summary>
        /// 64位MD5加密，无法解密
        /// </summary>
        /// <param name="password">密码</param>
        /// <returns>加密后的密码</returns>
        public static string MD5Encrypt64(string password)
        {
            string cl = password;
            MD5 md5 = MD5.Create(); //实例化一个md5对像
            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(cl));
            return Convert.ToBase64String(s);
        }
        #endregion

        #region  ========（四、）结合(16位与32位)判断加密，无法解密========
        /// <summary>
        /// 加密用户密码，无法解密
        /// </summary>
        /// <param name="password">密码</param>
        /// <param name="codeLength">加密位数</param>
        /// <returns>加密后的密码</returns>
        public static string md5(string password, int codeLength)
        {
            if (!string.IsNullOrEmpty(password))
            {
                // 16位MD5加密（取32位加密的9~25字符）  
                if (codeLength == 16)
                {
                    return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(password, "MD5").ToLower().Substring(8, 16);
                }

                // 32位加密
                if (codeLength == 32)
                {
                    return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(password, "MD5").ToLower();
                }
            }
            return string.Empty;
        }
        #endregion


        //第二种：通过DESCryptoServiceProvider对象对字符串进行加密解密
        #region  ========（方式一、）DES数据加密与解密========
        /// <summary>
        /// DES数据加密
        /// </summary>
        /// <param name="targetValue">目标值</param>
        /// <param name="key">密钥，自己设置的一个字符串</param>
        /// <returns>加密后的密码</returns>
        public static string Encrypt(string targetValue, string key)
        {
            if (string.IsNullOrEmpty(targetValue))
            {
                return string.Empty;
            }

            var returnValue = new StringBuilder();
            var des = new DESCryptoServiceProvider();
            byte[] inputByteArray = Encoding.Default.GetBytes(targetValue);
            // 通过两次哈希密码设置对称算法的初始化向量   
            des.Key = Encoding.ASCII.GetBytes(FormsAuthentication.HashPasswordForStoringInConfigFile
                                                    (FormsAuthentication.HashPasswordForStoringInConfigFile(key, "md5").
                                                        Substring(0, 8), "sha1").Substring(0, 8));
            // 通过两次哈希密码设置算法的机密密钥   
            des.IV = Encoding.ASCII.GetBytes(FormsAuthentication.HashPasswordForStoringInConfigFile
                                                    (FormsAuthentication.HashPasswordForStoringInConfigFile(key, "md5")
                                                        .Substring(0, 8), "md5").Substring(0, 8));
            var ms = new MemoryStream();
            var cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            foreach (byte b in ms.ToArray())
            {
                returnValue.AppendFormat("{0:X2}", b);
            }
            return returnValue.ToString();
        }

        /// <summary>
        /// DES数据解密
        /// </summary>
        /// <param name="targetValue">目标值</param>
        /// <param name="key">密钥，自己设置的一个字符串</param>
        /// <returns>解密后的密码</returns>
        public static string Decrypt(string targetValue, string key)
        {
            if (string.IsNullOrEmpty(targetValue))
            {
                return string.Empty;
            }
            // 定义DES加密对象
            var des = new DESCryptoServiceProvider();
            int len = targetValue.Length / 2;
            var inputByteArray = new byte[len];
            int x, i;
            for (x = 0; x < len; x++)
            {
                i = Convert.ToInt32(targetValue.Substring(x * 2, 2), 16);
                inputByteArray[x] = (byte)i;
            }
            // 通过两次哈希密码设置对称算法的初始化向量   
            des.Key = Encoding.ASCII.GetBytes(FormsAuthentication.HashPasswordForStoringInConfigFile
                                                    (FormsAuthentication.HashPasswordForStoringInConfigFile(key, "md5").
                                                        Substring(0, 8), "sha1").Substring(0, 8));
            // 通过两次哈希密码设置算法的机密密钥   
            des.IV = Encoding.ASCII.GetBytes(FormsAuthentication.HashPasswordForStoringInConfigFile
                                                    (FormsAuthentication.HashPasswordForStoringInConfigFile(key, "md5")
                                                        .Substring(0, 8), "md5").Substring(0, 8));
            // 定义内存流
            var ms = new MemoryStream();
            // 定义加密流
            var cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return Encoding.Default.GetString(ms.ToArray());
        }
        #endregion

        #region  ========（方式二、）DES数据加密与解密========

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="Text">目标值</param>
        /// <returns>加密后的密码</returns>
        public static string Encrypt2(string Text)
        {
            return Encrypt2(Text, "pan");//pan为自己设置的一个字符串
        }
        /// <summary> 
        /// 加密数据 
        /// </summary> 
        /// <param name="Text">目标值</param> 
        /// <param name="sKey">密钥，自己设置的一个字符串</param> 
        /// <returns>加密后的密码</returns> 
        public static string Encrypt2(string Text, string sKey)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray;
            inputByteArray = Encoding.Default.GetBytes(Text);
            des.Key = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
            des.IV = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
            {
                ret.AppendFormat("{0:X2}", b);
            }
            return ret.ToString();
        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="Text">目标值</param>
        /// <returns>解密后的密码</returns>
        public static string Decrypt2(string Text)
        {
            return Decrypt2(Text, "pan");//pan为自己设置的一个字符串
        }
        /// <summary> 
        /// 解密数据 
        /// </summary> 
        /// <param name="Text">目标值</param> 
        /// <param name="sKey">密钥</param> 
        /// <returns>解密后的密码</returns> 
        public static string Decrypt2(string Text, string sKey)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            int len;
            len = Text.Length / 2;
            byte[] inputByteArray = new byte[len];
            int x, i;
            for (x = 0; x < len; x++)
            {
                i = Convert.ToInt32(Text.Substring(x * 2, 2), 16);
                inputByteArray[x] = (byte)i;
            }
            des.Key = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
            des.IV = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return Encoding.Default.GetString(ms.ToArray());
        }

        #endregion
    }
}