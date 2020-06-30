﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Entities.Models;

namespace Blog.Services.Interfaces
{
	public interface IRoleService : IBaseService<Role>
	{
		Task<Role> GetRoleByName(string roleName);
	}
}
