﻿using System;
using System.Collections.Generic;
using Rainbow.Model;
using ScsContentMigrator.Services.Interface;
using SitecoreSidekick.Shared.IoC;

namespace ScsContentMigrator.Models
{
	public class ChildrenItemDataModel
	{
		private readonly IRemoteContentService _remote;
		public ChildrenItemDataModel()
		{
			_remote = Bootstrap.Container.Resolve<IRemoteContentService>();
		}

		public List<Guid> Children { get; set; }
		public string Item { get; set; }

		public IItemData ItemData(string itemId)
		{
			return _remote.DeserializeYaml(Item, itemId);
		}
	}
}
