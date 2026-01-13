namespace SnakeForms
{
    public class Classifica
    {
        public Punteggio[] Punteggi = new Punteggio[100];
        public int Count = 0;

        public void Aggiungi(Punteggio p)
        {
            if (Count < Punteggi.Length)
            {
                Punteggi[Count] = p;
                Count++;
            }
        }

        public void Elimina(int index)
        {
            if (index < 0 || index >= Count) return;

            for (int i = index; i < Count - 1; i++)
                Punteggi[i] = Punteggi[i + 1];

            Count--;
        }
    }
}
