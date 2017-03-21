using System.Collections.Generic;

namespace PhoneKeyboardPresenter
{
    public  class RuKeyBoard
    {
        private  readonly Dictionary<char, string> _ru = new Dictionary<char, string>
        {
            {' ', "0" },
            {'А', "2" },
            {'Б', "22" },
            {'В', "222" },
            {'Г', "2222" },
            {'Д', "3" },
            {'Е', "33" },
            {'Ж', "333" },
            {'З', "3333" },
            {'И', "4" },
            {'Й', "44" },
            {'К', "444" },
            {'Л', "4444" },
            {'М', "5" },
            {'Н', "55" },
            {'О', "555" },
            {'П', "5555" },
            {'Р', "6" },
            {'С', "66" },
            {'Т', "666" },
            {'У', "6666" },
            {'Ф', "7" },
            {'Х', "77" },
            {'Ц', "777" },
            {'Ч', "7777" },
            {'Ш', "8" },
            {'Щ', "88" },
            {'Ъ', "888" },
            {'Ы', "8888" },
            {'Ь', "9" },
            {'Э', "99" },
            {'Ю', "999" },
            {'Я', "9999" },
        };

        public string GetValue(char key)
        {
            var result = _ru.ContainsKey(key) ? _ru[key] : "Ты втираешь мне какую - то дичь!!!";
            return result;
        }
    }
}
