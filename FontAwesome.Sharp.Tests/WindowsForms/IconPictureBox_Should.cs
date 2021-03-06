using FluentAssertions;
using NEdifis.Attributes;
using NUnit.Framework;

namespace FontAwesome.Sharp.Tests.WindowsForms
{
    [TestFixtureFor(typeof(IconPictureBox))]
    // ReSharper disable once InconsistentNaming
    internal class IconPictureBox_Should
    {
        [Test]
        [TestCase(IconChar.Accusoft)]
        public void Be_Creatable(IconChar icon)
        {
            var pictureBox = new IconPictureBox { IconChar = icon };
            pictureBox.Should().NotBeNull();
        }

        [Test,
         Issue("https://github.com/awesome-inc/FontAwesome.Sharp/issues/20", Title =
             "FontAwesome v5.8.2 icons not displaying")]
        [TestCase(IconChar.AngleDoubleLeft)]
        [TestCase(IconChar.Stackpath)]
        public void Display_Icons(IconChar icon)
        {
            var pictureBox = new IconPictureBox { IconChar = icon };
            pictureBox.Image.Should().NotBeNull();
        }
    }
}
