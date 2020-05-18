using Domain.Core;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services {
    public class CarritoDomainService {
        private IRepository<Carrito> repository;

        public CarritoDomainService(IRepository<Carrito> repository) {
            this.repository = repository;
        }

        public void HacerPedido(Carrito item) {
            repository.Add(item);
        }
    }
}
