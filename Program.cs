using System;

public interface IVoador
{
    void Decolar();
    void Planar();
    void Pousar();
    void Cair();
}

public interface IPairador : IVoador
{
    void Pairar();
}

public interface IServivo
{
    void Comer();
    void Dormir();
    void Respirar();
    void Morrer();
}

public interface IMaquina
{
    void Ligar();
    void Desligar();
    void Abastecer();
    void Alerta();
}

class Program
{
    public Program()
    {
    }

    static void Main(string[] args)
    {
        Dinossauro dinossauro = new Dinossauro();
        dinossauro.Comer();
        dinossauro.Dormir();
        dinossauro.Respirar();
        dinossauro.Morrer();

        Trem trem = new Trem();
        trem.Ligar();
        trem.Desligar();
        trem.Abastecer();
        trem.Alerta();

        Helicoptero helicoptero = new Helicoptero();
        helicoptero.Ligar();
        helicoptero.Decolar();
        helicoptero.Pairar();
        helicoptero.Pousar();
        helicoptero.Desligar();

        Passaro passaro = new Passaro();
        passaro.Decolar();
        passaro.Comer();

        Aviao aviao = new Aviao();
        aviao.Ligar();
        aviao.Desligar();
        aviao.Decolar();
        aviao.Abastecer();

        Fantasma fantasma = new Fantasma();
        fantasma.Pairar();

        Superman superman = new Superman();
        superman.Decolar();
        superman.Comer();

        Gato gato = new Gato();
        gato.Comer();
        gato.Morrer();

        Carro carro = new Carro();
        carro.Ligar();
        carro.Abastecer();

        Cao cao = new Cao();
        cao.Comer();
        cao.Dormir();

        OVNI ovni = new OVNI();
        ovni.Decolar();
        ovni.Alerta();
    }
}

public class Dinossauro : IServivo
{
    public void Comer() => Console.WriteLine("O dinossauro está comendo.");
    public void Dormir() => Console.WriteLine("O dinossauro está dormindo.");
    public void Respirar() => Console.WriteLine("O dinossauro está respirando.");
    public void Morrer() => Console.WriteLine("O dinossauro morreu.");
}

public class Trem : IMaquina
{
    public void Ligar() => Console.WriteLine("O trem está ligado.");
    public void Desligar() => Console.WriteLine("O trem está desligado.");
    public void Abastecer() => Console.WriteLine("O trem está sendo abastecido.");
    public void Alerta() => Console.WriteLine("Alerta do trem acionado.");
}

public class Helicoptero : IPairador, IMaquina
{
    public void Decolar() => Console.WriteLine("O helicóptero decolou.");
    public void Planar() => Console.WriteLine("O helicóptero está planando.");
    public void Pousar() => Console.WriteLine("O helicóptero pousou.");
    public void Cair() => Console.WriteLine("O helicóptero caiu.");
    public void Pairar() => Console.WriteLine("O helicóptero está pairando.");

    public void Ligar() => Console.WriteLine("O helicóptero está ligado.");
    public void Desligar() => Console.WriteLine("O helicóptero está desligado.");
    public void Abastecer() => Console.WriteLine("O helicóptero está sendo abastecido.");
    public void Alerta() => Console.WriteLine("Alerta do helicóptero acionado.");
}

public class Passaro : IVoador, IServivo
{
    public void Decolar() => Console.WriteLine("O pássaro decolou.");
    public void Planar() => Console.WriteLine("O pássaro está planando.");
    public void Pousar() => Console.WriteLine("O pássaro pousou.");
    public void Cair() => Console.WriteLine("O pássaro caiu.");

    public void Comer() => Console.WriteLine("O pássaro está comendo.");
    public void Dormir() => Console.WriteLine("O pássaro está dormindo.");
    public void Respirar() => Console.WriteLine("O pássaro está respirando.");
    public void Morrer() => Console.WriteLine("O pássaro morreu.");
}

public class Aviao : IVoador, IMaquina
{
    public void Decolar() => Console.WriteLine("O avião decolou.");
    public void Planar() => Console.WriteLine("O avião está planando.");
    public void Pousar() =>

Console.WriteLine("O avião pousou.");
    public void Cair() => Console.WriteLine("O avião caiu.");
    public void Pairar() => Console.WriteLine("O avião está pairando.");

    public void Ligar() => Console.WriteLine("O avião está ligado.");
    public void Desligar() => Console.WriteLine("O avião está desligado.");
    public void Abastecer() => Console.WriteLine("O avião está sendo abastecido.");
    public void Alerta() => Console.WriteLine("Alerta do avião acionado.");
}

public class Fantasma : IPairador
{
    public void Decolar() => Console.WriteLine("O fantasma decolou.");
    public void Planar() => Console.WriteLine("O fantasma está planando.");
    public void Pousar() => Console.WriteLine("O fantasma pousou.");
    public void Cair() => Console.WriteLine("O fantasma caiu.");
    public void Pairar() => Console.WriteLine("O fantasma está pairando.");
}

public class Superman : IVoador, IPairador, IServivo
{
    public void Decolar() => Console.WriteLine("Superman decolou.");
    public void Planar() => Console.WriteLine("Superman está planando.");
    public void Pousar() => Console.WriteLine("Superman pousou.");
    public void Cair() => Console.WriteLine("Superman caiu.");
    public void Pairar() => Console.WriteLine("Superman está pairando.");

    public void Comer() => Console.WriteLine("Superman está comendo.");
    public void Dormir() => Console.WriteLine("Superman está dormindo.");
    public void Respirar() => Console.WriteLine("Superman está respirando.");
    public void Morrer() => Console.WriteLine("Superman é imortal.");
}
public class Gato : IServivo
{
    public void Comer() => Console.WriteLine("O gato está comendo.");
    public void Dormir() => Console.WriteLine("O gato está dormindo.");
    public void Respirar() => Console.WriteLine("O gato está respirando.");
    public void Morrer() => Console.WriteLine("O gato morreu.");
}

public class Carro : IMaquina
{
    public void Ligar() => Console.WriteLine("O carro está ligado.");
    public void Desligar() => Console.WriteLine("O carro está desligado.");
    public void Abastecer() => Console.WriteLine("O carro está sendo abastecido.");
    public void Alerta() => Console.WriteLine("Alerta do carro acionado.");
}

public class Cao : IServivo
{
    public void Comer() => Console.WriteLine("O cão está comendo.");
    public void Dormir() => Console.WriteLine("O cão está dormindo.");
    public void Respirar() => Console.WriteLine("O cão está respirando.");
    public void Morrer() => Console.WriteLine("O cão morreu.");
}

public class OVNI : IVoador, IMaquina
{
    public void Decolar() => Console.WriteLine("O OVNI decolou.");
    public void Planar() => Console.WriteLine("O OVNI está planando.");
    public void Pousar() => Console.WriteLine("O OVNI pousou.");
    public void Cair() => Console.WriteLine("O OVNI caiu.");

    public void Ligar() => Console.WriteLine("O OVNI está ligado.");
    public void Desligar() => Console.WriteLine("O OVNI está desligado.");
    public void Abastecer() => Console.WriteLine("O OVNI está sendo abastecido.");
    public void Alerta() => Console.WriteLine("Alerta do OVNI acionado.");
}