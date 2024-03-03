string sSourceData = "ugkcyxxp";
int counter = -1;
string password = "";
bool whileControl = false;

string CreateMD5(string input)
{
    // Use input string to calculate MD5 hash
    using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
    {
        byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
        byte[] hashBytes = md5.ComputeHash(inputBytes);

        return Convert.ToHexString(hashBytes);

    }
}

for (int i = 0; i < 8; ++i)
{   
    whileControl = false;
    do
    {
        ++counter;
        string hash = CreateMD5(sSourceData + counter);
        if (hash.StartsWith("00000"))
        {
            password += hash[5];
            whileControl = true;
        }
    }
    while (!whileControl);

}

Console.WriteLine(password);