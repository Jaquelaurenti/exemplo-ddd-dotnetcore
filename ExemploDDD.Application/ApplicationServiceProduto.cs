﻿using AutoMapper;
using ExemploDDD.Application.Dtos;
using ExemploDDD.Application.Interfaces;
using ExemploDDD.Domain.Core.Interfaces.Services;
using ExemploDDD.Domain.Entitys;
using System.Collections.Generic;

namespace ExemploDDD.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto serviceProduto;
        private readonly IMapper mapper;

        public ApplicationServiceProduto(IServiceProduto serviceProduto
                                        , IMapper mapper)
        {
            this.serviceProduto = serviceProduto;
            this.mapper = mapper;
        }

        public void Add(ProdutoDto produtoDto)
        {
            var produto = mapper.Map<Produto>(produtoDto);
            serviceProduto.Add(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            var produtos = serviceProduto.GetAll();
            var produtosDto = mapper.Map<IEnumerable<ProdutoDto>>(produtos);
            return produtosDto;
        }

        public ProdutoDto GetById(int id)
        {
            var produto = serviceProduto.GetById(id);
            var produtoDto = mapper.Map<ProdutoDto>(produto);
            return produtoDto;
        }

        public void Remove(ProdutoDto produtoDto)
        {
            var produto = mapper.Map<Produto>(produtoDto);
            serviceProduto.Remove(produto);
        }

        public void Update(ProdutoDto produtoDto)
        {
            var produto = mapper.Map<Produto>(produtoDto);
            serviceProduto.Update(produto);
        }
    }
}