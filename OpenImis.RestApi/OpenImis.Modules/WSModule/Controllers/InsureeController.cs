﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using OpenImis.Modules.WSModule.Repositories;
using OpenImis.Modules.WSModule.Models;

namespace OpenImis.Modules.WSModule.Controllers
{
	/// <summary>
	/// This class is actual implementation of IInsureeController methods for Master Version implementation 
	/// </summary>
	public class InsureeController: IInsureeController
    {

		private readonly IInsureeRepository _insureeRepository;

        public InsureeController()
        {
			_insureeRepository = new InsureeRepository();
        }

		/// <summary>
		/// Get insuree by insuree number
		/// </summary>
		/// <param name="chfId"></param>
		/// <returns>InsureeModel</returns>
		public async Task<InsureeModel> GetInsuree(string chfId)
		{
			// Validate input
			
			// Execute business behaviour
			InsureeModel insuree;
			insuree = await _insureeRepository.GetInsureeByCHFIDAsync(chfId);

			// Validate results

			// Validate data access rights

			// Return results 
			return insuree;
		}

	}
}
