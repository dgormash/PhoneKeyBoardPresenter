
using NUnit.Framework;
using PhoneKeyboardPresenter;

namespace PhoneKeyBoardTests
{
    [TestFixture]
    public class KeyboardTests
    {
        [Test]
        public void ALetterTest()
        {
            var keyBoard = new RuKeyBoard();
            Assert.AreEqual("2",keyBoard.GetValue('А'));
        }

        [Test]
        public void BLetterTest()
        {
            var keyBoard = new RuKeyBoard();
            Assert.AreEqual("22", keyBoard.GetValue('Б'));
        }

        [Test]
        public void VLetterTest()
        {
            var keyBoard = new RuKeyBoard();
            Assert.AreEqual("222", keyBoard.GetValue('В'));
        }

        [Test]
        public void GLetterTest()
        {
            var keyBoard = new RuKeyBoard();
            Assert.AreEqual("2222", keyBoard.GetValue('Г'));
        }

        [Test]
        public void AaCombinationTest()
        {
            var sequence = new SequensePresenter();
            Assert.AreEqual("2 2", sequence.TranslateToSequense("аа".ToUpper()));
        }

        [Test]
        public void AbCombinationTest()
        {
            var sequence = new SequensePresenter();
            Assert.AreEqual("2 22", sequence.TranslateToSequense("аб".ToUpper()));
        }

        [Test]
        public void AbvCombinationTest()
        {
            var sequence = new SequensePresenter();
            Assert.AreEqual("2 22 222", sequence.TranslateToSequense("абв".ToUpper()));
        }

        [Test]
        public void AbvgCombinationTest()
        {
            var sequence = new SequensePresenter();
            Assert.AreEqual("2 22 222 2222", sequence.TranslateToSequense("абвг".ToUpper()));
        }

        [Test]
        public void PotTest()
        {
            var sequence = new SequensePresenter();
            Assert.AreEqual("5555 555666", sequence.TranslateToSequense("пот".ToUpper()));
        }

        [Test]
        public void MamaTest()
        {
            var sequence = new SequensePresenter();
            Assert.AreEqual("5252", sequence.TranslateToSequense("МАМА".ToUpper()));
        }

        [Test]
        public void HelloWorldTest()
        {
            var sequence = new SequensePresenter();
            Assert.AreEqual("555564222336660546", sequence.TranslateToSequense("привет мир".ToUpper()));
        }

        [Test]
        public void SomeDichTest()
        {
            var sequence = new SequensePresenter();
            Assert.AreEqual("Ты втираешь мне какую - то дичь!!!", sequence.TranslateToSequense("hello world".ToUpper()));
        }

    }
}
