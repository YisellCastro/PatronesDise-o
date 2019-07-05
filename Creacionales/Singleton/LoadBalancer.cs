using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <resumen> 

    /// La clase 'Singleton'

    /// </resumen> 

  class LoadBalancer

  {
    private static LoadBalancer _instance;
    private List<string> _servers = new List<string>();
    private Random _random = new Random();

    // Bloquear objeto de sincronización

    private static object syncLock = new object();

    // Constructor (protegido)

    protected LoadBalancer()
    {
        // Lista de servidores disponibles

      _servers.Add("ServerI");
      _servers.Add("ServerII");
      _servers.Add("ServerIII");
      _servers.Add("ServerIV");
      _servers.Add("ServerV");
    }
 
    public static LoadBalancer GetLoadBalancer()
    {
        // Soporta aplicaciones multiproceso a través de

        // Patrón de "doble control de bloqueo" que (una vez

        // la instancia existe) evita bloquear cada

        // hora en que se invoca el método

      if (_instance == null)
      {
        lock (syncLock)
        {
          if (_instance == null)
          {
            _instance = new LoadBalancer();
          }
        }
      }
 
      return _instance;
    }

    // Equilibrador de carga aleatorio simple pero efectivo

    public string Server
    {
      get

      {
        int r = _random.Next(_servers.Count);
        return _servers[r].ToString();
      }
    }
  }
}
