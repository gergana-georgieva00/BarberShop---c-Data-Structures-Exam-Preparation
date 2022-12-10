using System;
using System.Collections.Generic;
using System.Linq;

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
            => barbersByNames.Values;

        public IEnumerable<Client> GetClients()
            => clientsByNames.Values;

        public void AssignClient(Barber b, Client c)
        {
            if (!clientsByNames.ContainsKey(c.Name))
            {
                throw new ArgumentException();
            }
            if (!barbersByNames.ContainsKey(b.Name))
            {
                throw new ArgumentException();
            }

            b.Clients.Add(c);
            c.Barber = b;
        }

        public void DeleteAllClientsFrom(Barber b)
        {
            if (!barbersByNames.ContainsKey(b.Name))
            {
                throw new ArgumentException();
            }

            var collection = b.Clients;
            b.Clients.Clear();

            foreach (var client in collection)
            {
                client.Barber = null;
            }
        }

        public IEnumerable<Client> GetClientsWithNoBarber()
            => clientsByNames.Values.Where(c => c.Barber is null);

        public IEnumerable<Barber> GetAllBarbersSortedWithClientsCountDesc()
            => barbersByNames.Values.OrderByDescending(b => b.Clients.Count);

        public IEnumerable<Barber> GetAllBarbersSortedWithStarsDecsendingAndHaircutPriceAsc()
            => barbersByNames.Values.OrderByDescending(b => b.Stars).ThenBy(b => b.HaircutPrice);

        public IEnumerable<Client> GetClientsSortedByAgeDescAndBarbersStarsDesc()
            => clientsByNames.Values.OrderByDescending(c => c.Age).ThenByDescending(c => c.Barber.Stars);
    }
}
