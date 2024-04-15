using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface INotificable
{
    void Notificar();
}

public class NotificacionEmail : INotificable
{
    public string DireccionCorreo { get; set; }

    public void Notificar()
    {
        Console.WriteLine($"Enviando email a {DireccionCorreo}");

    }
}


public class NotificacionWhatsapp : INotificable
{
    public string NumeroTelefono { get; set; }

    public void Notificar()
    {
        Console.WriteLine($"Enviando mensaje por WhatsApp al número {NumeroTelefono}");
  
    }
}

public class NotificacionSMS : INotificable
{
    public string NumeroTelefono { get; set; }

    public void Notificar()
    {
        Console.WriteLine($"Enviando SMS al número {NumeroTelefono}");
        
    }
}

class Program
{
    static void Main(string[] args)
    {

        var notificacionEmail = new NotificacionEmail { DireccionCorreo = "ejemplo@gmail.com" };
        var notificacionWhatsapp = new NotificacionWhatsapp { NumeroTelefono = "+1234567890" };
        var notificacionSMS = new NotificacionSMS { NumeroTelefono = "+1234567890" };


        notificacionEmail.Notificar();
        notificacionWhatsapp.Notificar();
        notificacionSMS.Notificar();


        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
