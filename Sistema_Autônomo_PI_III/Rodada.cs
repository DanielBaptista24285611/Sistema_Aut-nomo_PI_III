using System;
using System.Collections.Generic;
using System.Linq;

public enum FaseRodada
{
    Promocao,
    Votacao
}

public class Rodada
{
    public int NumeroRodada { get; private set; }
    public FaseRodada FaseAtual { get; private set; }
    public List<string> PersonagensPromovidos { get; private set; }
    private Dictionary<string, bool> votos;
    private HashSet<string> jogadoresQueVotaram;

    public Rodada(int numero, string jogadorInicial)
    {
        NumeroRodada = numero;
        FaseAtual = FaseRodada.Promocao;
        PersonagensPromovidos = new List<string>();
        votos = new Dictionary<string, bool>();
        jogadoresQueVotaram = new HashSet<string>();
    }

    public bool PodePromover()
    {
        return PersonagensPromovidos.Count < 3;
    }

    public bool PromoverPersonagem(string nome)
    {
        if (FaseAtual != FaseRodada.Promocao || PersonagensPromovidos.Contains(nome) || !PodePromover())
            return false;

        PersonagensPromovidos.Add(nome);

        if (PersonagensPromovidos.Count == 3)
        {
            FaseAtual = FaseRodada.Votacao;
        }

        return true;
    }

    public bool RegistrarVoto(string jogador, bool voto)
    {
        if (FaseAtual != FaseRodada.Votacao || jogadoresQueVotaram.Contains(jogador))
            return false;

        votos[jogador] = voto;
        jogadoresQueVotaram.Add(jogador);
        return true;
    }

    public bool TodosVotaram(List<string> todosJogadores)
    {
        return todosJogadores.All(j => jogadoresQueVotaram.Contains(j.Trim().ToUpper()));
    }

    public int ObterTotalVotos()
    {
        return votos.Count;
    }

    public string ResultadoVotacao()
    {
        int votosSim = votos.Values.Count(v => v);
        int votosNao = votos.Values.Count(v => !v);

        return votosSim > votosNao ? "Aprovado" : "Rejeitado";
    }

    public override string ToString()
    {
        string status = $"Rodada {NumeroRodada} - Fase: {FaseAtual}";
        if (FaseAtual == FaseRodada.Promocao)
        {
            status += $" - Promovidos: {string.Join(", ", PersonagensPromovidos)}";
        }
        else if (FaseAtual == FaseRodada.Votacao)
        {
            status += $" - Votos registrados: {ObterTotalVotos()}";
        }
        return status;
    }
}
