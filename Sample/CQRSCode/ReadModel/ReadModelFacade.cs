﻿using System;
using System.Collections.Generic;
using CQRSCode.ReadModel.Dtos;
using CQRSCode.ReadModel.Infrastructure;
using CQRSlite.Domain;

namespace CQRSCode.ReadModel
{
    public class ReadModelFacade : IReadModelFacade
    {
        private readonly ISession session;

        public ReadModelFacade(ISession session)
        {
            this.session = session;
        }

        public IEnumerable<InventoryItemListDto> GetInventoryItems()
        {
            return InMemoryDatabase.List;
        }

        public InventoryItemDetailsDto GetInventoryItemDetails(Guid id)
        {
            return InMemoryDatabase.Details[id];
        }
    }
}