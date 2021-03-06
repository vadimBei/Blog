﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Entities.Models;
using Blog.Repository;
using Blog.Services.Interfaces;

namespace Blog.Services
{
	public class CategoryService : BaseService<Category>, ICategoryService
	{
		private Repository<Category> _repository;

		public CategoryService(BlogContext blogContext)
			: base(blogContext)
		{
			_repository = new Repository<Category>(blogContext);
		}

		public async override Task<Category> GetByIdAsync(Guid id)
		{
			return (await _repository.FindByConditionAsync(c => c.Id == id)).FirstOrDefault();
		}

		public async Task<IEnumerable<string>> GetByPrefixAsync(string Prefix)
		{
			return (await _repository.FindByConditionAsync(c => c.Name.StartsWith(Prefix))).Select(c => c.Name);
		}
	}
}
