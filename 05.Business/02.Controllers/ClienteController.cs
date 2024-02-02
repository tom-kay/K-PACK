using System;

namespace _05.Business.Controllers
{
	class ClienteController
	{
		//ClienteView Vista;
		//Constructor

		//public ClienteController(ClienteView View)
		public ClienteController()
		{
			//Vista = View;
			////inicializar eventos
			//Vista.Load += new EventHandler(ClientList);
		}

		private void ClientList(object sender, EventArgs e)
		{
			//ClienteDao db = new ClienteDao();
			//Vista.TablaCliente.DataSource = db.VerRegistros(Vista.txtBuscar.Text);
		}
	}
}
