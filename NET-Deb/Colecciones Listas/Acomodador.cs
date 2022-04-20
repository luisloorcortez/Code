
internal class Acomodador
{
    public List<int> Ordenados(List<int> List)
    {
        for (int i = 0; i < List.Count && Ordenado == false; i++)
        {
            Ordenado = true;

            for (int j = 0; j < List.Count - 1; j++)
            {
                if (List[j] > List[j + 1])
                {
                    Ordenado = false;
                    Aux = List[j];
                    List[j] = List[j + 1];
                    List[j + 1] = Aux;
                }
            }
        }

        return List;
    }

    private bool Ordenado = false;
    private int Aux;
}
