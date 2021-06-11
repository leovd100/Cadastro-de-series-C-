using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroDeSeries
{
    public class SerieRepositorio : IRepositorio<Series>
    {


        private List<Series> _listaSeries = new List<Series>();

        public void Atualiza(int id, Series objeto)
        {
            _listaSeries[id] = objeto;
        }

        public void Exclui(int id)
        {
            _listaSeries[id].Excluir();
        }

        public void Insere(Series entidade)
        {
            _listaSeries.Add(entidade);
        }

        public List<Series> Lista()
        {
            return _listaSeries;
        }

        public int ProximoId()
        {
            return _listaSeries.Count;
        }

        public Series RetornaPorId(int id)
        {
            return _listaSeries[id];
        }


        
       
       

      

      
      
     
    }


}
