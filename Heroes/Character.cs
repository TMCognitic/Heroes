class Character
{
    private int _end, _for;

    public int End
    {
        get
        {
            return _end + Race.ModifEnd;
        }

        private set
        {
            _end = value;
        }
    }

    public int For
    {
        get
        {
            return _for + Race.ModifFor;
        }

        private set
        {
            _for = value;
        }
    }

    public IRace Race
    {
        get;
    }

    public Character(IRace race)
    {
        End = Random.Shared.Next(10, 18);
        For = Random.Shared.Next(10, 18);

        Race = race;
    }

    public override string ToString()
    {
        return $"Je suis un {Race.Nom} avec une force de {_for} => {For} et une endurance de {_end} => {End}";
    }

}
