<Query Kind="Program">
  <Namespace>System.Security.Cryptography</Namespace>
</Query>

void Main()
{
	var a = Encrypt("Hello");
	Console.WriteLine(a);
}

static readonly string PasswordHash = "P@sSw0rd";
static readonly string SaltKey = "S@LT&KEY";
static readonly string VIKey = "@1B2c3D4e5F6g7H8";

public bool Match(string encryptData, string strData)
{
	string encryptUser = Encrypt(strData);
	string decryptUser = Decrypt(encryptData);
	if ((encryptData == encryptUser) && (decryptUser == strData))
	{
		return true;
	}
	else
	{
		return false;
	}
}

public string Encrypt(string plainText)
{
	byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

	byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
	var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
	var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));

	byte[] cipherTextBytes;

	using (var memoryStream = new MemoryStream())
	{
		using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
		{
			cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
			cryptoStream.FlushFinalBlock();
			cipherTextBytes = memoryStream.ToArray();
			cryptoStream.Close();
		}
		memoryStream.Close();
	}
	return Convert.ToBase64String(cipherTextBytes);
}

public string Decrypt(string encryptedText)
{
	var result = encryptedText;

	try
	{

		byte[] cipherTextBytes = Convert.FromBase64String(encryptedText);
		byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
		var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

		var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
		var memoryStream = new MemoryStream(cipherTextBytes);
		var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
		byte[] plainTextBytes = new byte[cipherTextBytes.Length];

		int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
		memoryStream.Close();
		cryptoStream.Close();

		result = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
	}
	catch (Exception ex)
	{
		throw ex;
	}

	return result;
}

// Define other methods and classes here
