using TextTools.Model;

namespace TextTools.Pages
{
    public partial class Home
    {
        readonly List<Tool> basicTools = [];
        readonly List<Tool> textManipulationTools = [];
        public Home()
        {
            BasicTools();
            TextManipulation();
        }
        void BasicTools()
        {
            basicTools.Clear();
            basicTools.Add(new Tool()
            {
                Heading= "Sort Text",
                ShortDescrption= "Sort a list in alphabetical, natural, reverse, or random order.",
                ImageUrl = "https://picsum.photos/150"
            });
            basicTools.Add(new Tool()
            {
                Heading = "Convert Case",
                ShortDescrption = "Change the letter case to uppercase, lowercase, title case, sentence case, or capitalize.",
                ImageUrl = "https://picsum.photos/150"
            });
            basicTools.Add(new Tool()
            {
                Heading = "Find & Replace",
                ShortDescrption = "Find all the instances the text appears in a text and replace it with another word.",
                ImageUrl = "https://picsum.photos/150"
            });
            basicTools.Add(new Tool()
            {
                Heading = "Reverse List",
                ShortDescrption = "Flip a list vertically to transform a list in reverse order.",
                ImageUrl = "https://picsum.photos/150"
            });
            basicTools.Add(new Tool()
            {
                Heading = "Difference Checker",
                ShortDescrption = "Compare text files and find the difference between the two.",
                ImageUrl = "https://picsum.photos/150"
            });
            basicTools.Add(new Tool()
            {
                Heading = "Word Count",
                ShortDescrption = "Find out how many words, sentences, paragraphs, and characters you have written.",
                ImageUrl = "https://picsum.photos/150"
            });
        }
        void TextManipulation()
        {
            textManipulationTools.Clear();
            textManipulationTools.Add(new Tool()
            {
                Heading = "Sort Text",
                ShortDescrption = "Sort a list in alphabetical, natural, reverse, or random order.",
                ImageUrl = "https://picsum.photos/150"
            });
            textManipulationTools.Add(new Tool()
            {
                Heading = "Convert Case",
                ShortDescrption = "Change the letter case to uppercase, lowercase, title case, sentence case, or capitalize.",
                ImageUrl = "https://picsum.photos/150"
            });
            textManipulationTools.Add(new Tool()
            {
                Heading = "Find & Replace",
                ShortDescrption = "Find all the instances the text appears in a text and replace it with another word.",
                ImageUrl = "https://picsum.photos/150"
            });
            textManipulationTools.Add(new Tool()
            {
                Heading = "Reverse List",
                ShortDescrption = "Flip a list vertically to transform a list in reverse order.",
                ImageUrl = "https://picsum.photos/150"
            });
            textManipulationTools.Add(new Tool()
            {
                Heading = "Difference Checker",
                ShortDescrption = "Compare text files and find the difference between the two.",
                ImageUrl = "https://picsum.photos/150"
            });
            textManipulationTools.Add(new Tool()
            {
                Heading = "Word Count",
                ShortDescrption = "Find out how many words, sentences, paragraphs, and characters you have written.",
                ImageUrl = "https://picsum.photos/150"
            });
        }
    }
}
