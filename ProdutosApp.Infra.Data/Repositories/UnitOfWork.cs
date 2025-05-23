﻿using Microsoft.EntityFrameworkCore.Storage;
using ProdutosApp.Domain.Interfaces.Repositories;
using ProdutosApp.Domain.Interfaces.Repositories.ProdutosApp.Domain.Interfaces.Repositories;
using ProdutosApp.Infra.Data.Contexts;

namespace ProdutosApp.Infra.Data.Repositories
{
    /// <summary>
    /// Implementação da unidade de trabalho dos repositórios
    /// </summary>
    public class UnitOfWork(DataContext _dataContext) : IUnitOfWork
    {
        private IDbContextTransaction? _transaction;
        public async Task SaveChangesAsync() => await _dataContext.SaveChangesAsync();
        public void BeginTransaction() => _transaction = _dataContext.Database.BeginTransaction();

        public void Commit() => _transaction?.Commit();

        public void RollBack() => _transaction?.Rollback();
        public void Dispose()
        {
            _transaction?.Dispose();
            _dataContext?.Dispose();
        }

        public ICategoriaRepository CategoriaRepository => new CategoriaRepository(_dataContext);

        public IProdutoRepository ProdutoRepository => new ProdutoRepository(_dataContext);
    }
}
