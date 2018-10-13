﻿using LibraryManagementSystem.Application.Libraries.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Application.Libraries
{
	public interface ILibraryManager
	{
		Task<List<LibraryDto>> GetLibrariesAsync();
	}
}
