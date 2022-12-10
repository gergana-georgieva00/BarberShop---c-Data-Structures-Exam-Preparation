using System;
using System.Collections.Generic;

namespace BarberShop
{
    public class BarberShop : IBarberShop
    {
        Dictionary<string, Barber> barbersByNames = new Dictionary<string, Barber>();
        Dictionary<string, Client> clientsByNames = new Dictionary<string, Client>();

        public void AddBarber(Barber b)
        {
            if (barbersByNames.ContainsKey(b.Name))
            {
                throw new ArgumentException();
            }

            barbersByNames.Add(b.Name, b);
        }

        public void AddClient(Client c)
        {
            if (clientsByNames.ContainsKey(c.Name))
            {
                throw new ArgumentException();
            }

            clientsByNames.Add(c.Name, c);
        }

        public bool Exist(Barber b)
            => barbersByNames.ContainsKey(b.Name);

        public bool Exist(Client c)
            => clientsByNames.ContainsKey(c.Name);

        public IEnumerable<Barber> GetBarbers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetClients()
        {
            throw new NotImplementedException();
        }

        public void AssignClient(Barber b, Client c)
        {
            throw new NotImplementedException();
        }

        public void DeleteAllClientsFrom(Barber b)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetClientsWithNoBarber()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Barber> GetAllBarbersSortedWithClientsCountDesc()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Barber> GetAllBarbersSortedWithStarsDecsendingAndHaircutPriceAsc()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetClientsSortedByAgeDescAndBarbersStarsDesc()
        {
            throw new NotImplementedException();
        }
    }
}
