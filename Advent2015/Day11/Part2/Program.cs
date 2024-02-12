string input = "vzbxxzaa";

bool output = false;

while (output == false)
{
    bool hasTriple = false;
    bool noIOL = true;
    int doubleCounter = 0;
    for (int i = 0; i < input.Length; ++i)
    {
        if (i < input.Length - 2)
        {
            if (input[i + 1] == (input[i] + 1) && input[i + 2] == (input[i + 1] + 1))
            {
                hasTriple = true;
            }
        }

        if (input.Contains('i') || input.Contains('o') || input.Contains('l'))
        {
            noIOL = false;
        }

        if (i < input.Length - 1)
        {
            if (input[i] == input[i + 1])
            {
                ++doubleCounter;
            }
            if (i < input.Length - 2)
            {
                if (input[i] == input[i + 1] && input[i + 1] == input[i + 2])
                {
                    --doubleCounter;
                }
            }
        }
    }
    if (hasTriple && noIOL && doubleCounter >= 2)
    {
        output = true;
    }


    if (output)
    {
        Console.WriteLine(input);
    }
    else
    {
        char[] temp = input.ToCharArray();
        int j = temp.Length - 1;

        if (temp[temp.Length - 1] != 'z')
        {
            ++temp[temp.Length - 1];
        }
        else
        {
            temp[temp.Length - 1] = 'a';
            while (j > 0)
            {
                if (temp[--j] != 'z')
                {
                    ++temp[j];
                    j = -1;
                }
                else
                {
                    temp[j] = 'a';
                }
            }
        }
        input = string.Join("", temp);
    }
}
