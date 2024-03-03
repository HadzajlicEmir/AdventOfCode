string sSourceData = "ugkcyxxp";
int counter = -1;
char[] password = new char[8];
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
Array.Fill(password, '_');

for (int i = 0; i < 8; ++i)
{
    whileControl = false;
    do
    {
        ++counter;
        string hash = CreateMD5(sSourceData + counter);
        if (hash.StartsWith("00000"))
        {
            int value = -1;
            if (Char.IsDigit(hash[5]))
            {
                value = (int)char.GetNumericValue(hash[5]);
            }
            if (value >= 0 && value < 8)
            {
                if (password[value] == '_')
                {
                    password[value] = hash[6];
                    whileControl = true;
                    foreach (var character in password)
                    {
                        Console.Write(character);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
    while (!whileControl);
}
