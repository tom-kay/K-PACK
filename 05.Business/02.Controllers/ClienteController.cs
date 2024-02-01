using _05.Business.Models.Dao;
using _05.Business.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Business.Controllers
{
    class ClienteController
    {
        ClienteView Vista;
        //Constructor
        public ClienteController(ClienteView View)
        {
            Vista = View;
            //inicializar eventos
            Vista.Load += new EventHandler(ClientList);
        }

        private void ClientList(object sender, EventArgs e)
        {
            ClienteDao db = new ClienteDao();
            //Vista.TablaCliente.DataSource = db.VerRegistros(Vista.txtBuscar.Text);
        }
    }
}
