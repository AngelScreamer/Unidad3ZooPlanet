﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooPlanet.Models;
using ZooPlanet.Repositories;

namespace ZooPlanet.Services
{
	public class MenuServices
	{
		public IEnumerable<Clase> Clases { get; private set; }

		public MenuServices()
		{
			using (animalesContext context = new animalesContext())
			{
				ClasesRepository repository = new ClasesRepository(context);
				Clases = repository.GetAll().ToList();
			}
		}

		

	}
}
