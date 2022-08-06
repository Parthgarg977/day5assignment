namespace Simple
{
    class P9
    {
        public void VowelorConsonant()
        {
            Console.WriteLine("Enter alphabet");
            char a = Console.ReadLine()[0];
            if (a == 'a' || a == 'A' || a == 'e' || a == 'E' || a == 'i' || a == 'I' || a == 'o' || a == 'O' || a == 'u' || a == 'U')
            {
                Console.WriteLine("Entered alphabet " + a + " is vowel");
            }
            else
                Console.WriteLine("Entered alphabet " + a + " is consonant");
        }
    }
}