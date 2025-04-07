using System.Collections.Generic;
using System.Linq;

public class Votacao
{
    private Dictionary<string, bool> votos;

    public Votacao()
    {
        votos = new Dictionary<string, bool>();
    }

    public bool RegistrarVoto(string jogador, bool voto)
    {
        if (votos.ContainsKey(jogador))
            return false;

        votos[jogador] = voto;
        return true;
    }

    public bool TodosVotaram(List<string> jogadores)
    {
        return jogadores.All(j => votos.ContainsKey(j));
    }

    public int ObterTotalVotos()
    {
        return votos.Count;
    }

    public string ObterResultado()
    {
        int votosSim = votos.Values.Count(v => v);
        int votosNao = votos.Values.Count(v => !v);
        return $"Sim: {votosSim} | Não: {votosNao}";
    }
}
