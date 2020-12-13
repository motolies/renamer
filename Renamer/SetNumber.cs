using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Renamer
{
    class SetNumber
    {



        static string NumericPattern = @"\d+";
        // dot(.) 등 기타 문자도 포함할 경우는 regular expression을 수정 해야함.


        public static string FrontNumberSet(string input, int digitPrecision)
        {

            var regex = new Regex(NumericPattern);
            var matches = regex.Matches(input);
            var numberFormat = new string('0', digitPrecision); // "0000"
            var replacePosition = 0;
            Console.WriteLine(matches);

            var result = new StringBuilder();
            if (matches.Count > 0)
            {
                var match = matches[replacePosition];
                int number;
                var alphanum = int.TryParse(match.Value, out number)
                                    ? number.ToString(numberFormat)
                                    : match.Value;
                Console.WriteLine(match.Value);
                Console.WriteLine(number.ToString(numberFormat));
                Console.WriteLine(int.TryParse(match.Value, out number));
                Console.WriteLine(alphanum);
                result.Append(input.Substring(0, match.Index))
                        .Append(alphanum)
                        .Append(input.Substring(match.Index + match.Length));

                return result.ToString();
            }
            else
            {
                return input;
            }

        }

        public static string BackNumberSet(string input, int digitPrecision)
        {

            var regex = new Regex(NumericPattern);
            var matches = regex.Matches(input);
            var numberFormat = new string('0', digitPrecision); // "0000"
            var replacePosition = matches.Count - 1;
            Console.WriteLine(matches);

            var result = new StringBuilder();
            if (matches.Count > 0)
            {
                var match = matches[replacePosition];
                int number;
                var alphanum = int.TryParse(match.Value, out number)
                                    ? number.ToString(numberFormat)
                                    : match.Value;
                Console.WriteLine(match.Value);
                Console.WriteLine(number.ToString(numberFormat));
                Console.WriteLine(int.TryParse(match.Value, out number));
                Console.WriteLine(alphanum);
                result.Append(input.Substring(0, match.Index))
                        .Append(alphanum)
                        .Append(input.Substring(match.Index + match.Length));

                return result.ToString();
            }
            else
            {
                return input;
            }

        }

        public static bool filefolder(string path) // 파일이냐 폴더냐 구분메서드, 밑에 ExtractIcon 클래스와 함께 쓰인다.
        {

            if (System.IO.File.GetAttributes(path).ToString().StartsWith("Archive") == true)//이렇게 하면 파일의 경우
            {
                return true;
            }
            else //(File.GetAttributes(path).ToString().StartsWith("Archive") == false) //이렇게 하면 폴더의 경우를 이용할 수 있다.
            {
                return false;
            }


        }

    }

    
}
