namespace Source;

public class N0008StringToInteger
{
    public static int MyAtoi(string s)
    {
        int res = 0;
        int stage = 0;
        bool isPositive = true;
        int temp;

        foreach (char c in s)
        {
            if (stage == 0)
            {
                switch (c)
                {
                    case ' ':
                        continue;
                    case '+':
                        stage = 1;
                        break;
                    case '-':
                        isPositive = false;
                        stage = 1;
                        break;
                    default:
                        if (c >= '0' && c <= '9')
                        {
                            res = c - '0';
                            stage = 1;
                        }
                        else
                        {
                            return 0;
                        }
                        break;
                }
            }
            else if (stage == 1)
            {
                if (c >= '0' && c <= '9')
                {
                    if ((res > Int32.MaxValue / 10) || (res < Int32.MinValue / 10))
                    {
                        return isPositive? Int32.MaxValue : Int32.MinValue;
                    }

                    res *=10;
                    temp = isPositive ? res + (c - '0') : res - (c - '0');

                    if(res!=0&&(temp < 0) ^ (res < 0))
                    {
                        return isPositive ? Int32.MaxValue : Int32.MinValue;
                    }
                    res = temp;
                }
                else
                {
                    stage = 2;
                }
            }
            else
            {
                return res;
            }
        }
        return res;
    }
}
