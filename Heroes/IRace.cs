// See https://aka.ms/new-console-template for more information
interface IRace
{
    public static IRace Humain => new Race("Humain", 1, 1);
    public static IRace Nain => new Race("Nain", 2, 0);

    string Nom { get; }
    int ModifEnd { get; }
    int ModifFor { get; }
}
