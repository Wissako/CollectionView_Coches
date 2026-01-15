using CollectionViewEjemplo.Models;

namespace CollectionViewEjemplo.Pages;


public partial class CollectionViewDemo : ContentPage
{
	public CollectionViewDemo()
	{
		InitializeComponent();
		collectionView.ItemsSource = GetCoches();
	}
	private List<Coches> GetCoches()
	{
		return new List<Coches>
		{
			new Coches{nombreCoche = "Chaser",marcaCoche="Toyota",cocheUrl="https://tse1.mm.bing.net/th/id/OIP.t7BTYHqTzo1KqznOvr3vjQHaHa?rs=1&pid=ImgDetMain&o=7&rm=3"},
			new Coches{nombreCoche = "Silvia", marcaCoche="Nissan", cocheUrl="https://th.bing.com/th/id/R.d17dd9886749fb94fb1867c0ef86fe90?rik=mmEfb2SueHxLqw&riu=http%3a%2f%2fgomotors.net%2fphotos%2f97%2f8b%2fnissan-s15-silvia-first-gen-mx5miata_b4c81.jpg%3fi&ehk=3Kx9BfPSf1%2bvRmpfewLKp7fmvHhl93GHbUE%2bBeK%2f7tc%3d&risl=&pid=ImgRaw&r=0"},
			new Coches{nombreCoche = "Delta S4", marcaCoche="Lancia", cocheUrl="https://tse1.mm.bing.net/th/id/OIP.-5HvFI2jZ7FesGmldsrLLQHaFc?rs=1&pid=ImgDetMain&o=7&rm=3"},
			new Coches{nombreCoche = "Supra", marcaCoche="Toyota", cocheUrl="https://tse1.mm.bing.net/th/id/OIP.Yulyl0UNgLs6hWmeMaoemQHaEo?rs=1&pid=ImgDetMain&o=7&rm=3"},
			new Coches{nombreCoche = "Golf", marcaCoche="Volkswagen", cocheUrl="https://www.tuningblog.eu/wp-content/uploads/2021/06/Widebody-VW-Golf-Mk2-JP-Performance-9.jpg"},
			new Coches{nombreCoche = "Qattro", marcaCoche="Audi", cocheUrl="https://preview.redd.it/61rmo0d084p21.jpg?auto=webp&s=e8ca0971743a8d0d66dd25371628a4036e836dd9"},
			new Coches{nombreCoche = "Celica", marcaCoche="Toyota", cocheUrl="https://sodo-moto.com/wp-content/uploads/2018/07/fullsizeoutput_29af-762x456.jpeg"},
			new Coches{nombreCoche = "911", marcaCoche="Porsche", cocheUrl="https://www.hnlist.com/files/04-2021/ad184/porsche-911-carrera-964-sunburst-widebody-backdat-394643961_large.jpg"},
			new Coches{nombreCoche = "Skyline", marcaCoche="Nissan", cocheUrl="https://static1.topspeedimages.com/wordpress/wp-content/uploads/2023/03/resize_shutterstock_1536127892.jpg"},
			new Coches{nombreCoche = "M3", marcaCoche="BMW", cocheUrl="https://www.gtplanet.net/wp-content/uploads/2024/11/image-1-38.jpg"}


        };

	}
}