﻿string sSourceData = "iwrupvqb";
int counter = -1;

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

do {
    ++counter;
}
while (!CreateMD5(sSourceData + counter).StartsWith("000000"));


Console.WriteLine(counter);