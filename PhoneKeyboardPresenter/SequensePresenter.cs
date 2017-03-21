
namespace PhoneKeyboardPresenter
{
    public class SequensePresenter
    {
        public  string TranslateToSequense(string word)
        {
            var result = string.Empty;
            var keyBoard = new RuKeyBoard();

            foreach (var ch in word)
            {
                var curSequence = keyBoard.GetValue(ch);
                if (curSequence == "Ты втираешь мне какую - то дичь!!!") return curSequence;
                result += (result.Length == 0 || result[result.Length - 1] != curSequence[0]) ? curSequence : ' ' + curSequence;
            }
            return result;
        }
    }
}
