namespace Signatures
{
    public class Signature
    {
        /// <summary>
        /// Method prints a header at the start of a console app.
        /// </summary>
        /// <param name="title"></param>
        public static void Header(string title)
        {
            Console.Title = "-=-=-= " + title + " =-=-=-";
            Console.WriteLine("-=-=-= CSF@: Breaking New Ground On " + title.ToUpper() + " =-=-=-");
        }

    }
}