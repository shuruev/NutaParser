// возможно убрать state.Deep ©®℗™
// in и out в типах

using System;
using System.Linq;
using WpfInteractive;
using System.ComponentModel;
using PDMMaintenanceTool.Units;
using PDMMaintenanceTool.ValueList;
using PDMMaintenanceTool.Model;
using System.Windows.Input;

namespace PDMMaintenanceTool.AttrGroups
{
	public class AttrEditWrapper : IEditor, INotifyPropertyChanged
	{
		public static Uri Xaml { get { return new Uri(WindowsView.AppUri + "AttributeGroups/AttrEditWrapper.xaml"); } }
		public static readonly ICommand SaveCmd = new RoutedCommand();
		public static readonly ICommand CancelCmd = new RoutedCommand();

		public string Id { get { return m_data.GetAttrId(); } }
		public string Position { get { return m_data.Position.HasValue ? m_data.Position.ToString() : null; } }

		public string Name
		{
			get { return m_cash.Get(x => x.Name); }
			set { m_cash.Set(x => x.Name, value); }
		}

		public bool IsMultyVal
		{
			get { return m_cash.Get(x => x.IsMultyVal); }
			set { m_cash.Set(x => x.IsMultyVal, value); }
		}

		public string Comment
		{
			get { return m_cash.Get(x => x.Comment); }
			set { m_cash.Set(x => x.Comment, value); }
		}

		public string Group
		{
			get { return m_cash.Get(x => x.Group); }
			set { m_cash.Set(x => x.Group, value); }
		}

		public WrapperList ValueLists { get; private set; }
		public IWrapper ValueList
		{
			get { return m_cash.Get(x => x.ValueList); }
			set { m_cash.Set(x => x.ValueList, value); }
		}

		public WrapperList UnitLists { get; private set; }
		public IWrapper UnitList
		{
			get { return m_cash.Get(x => x.UnitList); }
			set { m_cash.Set(x => x.UnitList, value); }
		}

		public WrapperList AttrGroups { get; private set; }
		public IWrapper AttrGroup
		{
			get { return m_cash.Get(x => x.AttrGroup); }
			set { m_cash.Set(x => x.AttrGroup, value); }
		}

		public bool IsUpdate { get; private set; }

		IStorages m_stor;
		IAttr m_data;
		public IViewManager View { get; private set; }
		ValueCash<AttrEditWrapper> m_cash;

		AttrEditWrapper(IAttr data, IStorages stor, IViewManager view)
		{
			m_stor = stor;
			m_data = data;
			View = view;
			m_cash = new ValueCash<AttrEditWrapper>(this);

			UnitLists = new WrapperList();
			ValueLists = new WrapperList();
			AttrGroups = new WrapperList();

			RefreshDictionaries();
			LoadCash(m_data);
		}

		public event PropertyChangedEventHandler PropertyChanged
		{
			add { m_cash.PropertyChanged += value; }
			remove { m_cash.PropertyChanged -= value; }
		}

		public event Action<IAttr> OnSave;

		void LoadCash(IAttr data)
		{
			Name = data.Name;
			IsMultyVal = data.IsMultyVal;
			Comment = data.Comment;
			UnitList = UnitLists.Get(m_data.UnitList);
			ValueList = ValueLists.Get(m_data.ValueList);
			AttrGroup = AttrGroups.Get(m_data.Owner);
		}

		void LoadData(IAttr data)
		{
			data.Id = m_data.Id;
			data.Name = Name;
			data.IsMultyVal = IsMultyVal;
			data.Comment = Comment;
			data.UnitList = (IUnitList)UnitList.Data;
			/*data.ValueList = (IValueList)ValueList.Data;
			data.Owner = (IAttrGroup)AttrGroup.Data;*/
		}

		/*void RefreshDictionaries()
		{
			UnitLists.Add(EmptyWrapper.Value);
			UnitLists.AddRange(from x in m_stor.UnitLists.ReadUnitLists()
							   select new UnitListShortWrapper(x, View));

			ValueLists.Add(EmptyWrapper.Value);
			ValueLists.AddRange(from x in m_stor.ValueLists.ReadValueLists()
								select new ValueListShortWrapper(x, View));

			AttrGroups.AddRange(from x in m_stor.AttrGroups.AttrGroups
								select new AttrGroupShortWrapper(x, View));
		}

		public void Save()
		{
			if (!View.Safe(SaveStorage))
				return;

			var ev = OnSave;
			if (ev != null)
				ev(m_data);

			View.Back();
		}

		public void Back()
		{
			View.Back();
		}

		void SaveStorage()
		{
			var tempData = m_data.Owner.CreateAttr();
			LoadData(tempData);
			m_data.Owner.SaveAttrs(new[] { tempData });

			m_data = tempData;
		}

		public static AttrEditMode FromEdit(IAttr data, IStorages stor, IViewManager view)
		{
			return new AttrEditMode()
			{
				Source = new AttrEditWrapper(data, stor, view) { IsUpdate = true }
			};
		}

		public static AttrCreateMode FromCreate(IAttr data, IStorages stor, IViewManager view)
		{
			return new AttrCreateMode()
			{
				Source = new AttrEditWrapper(data, stor, view) { IsUpdate = false }
			};
		}*/
	}

	public class AttrEditMode : EditMode<AttrEditWrapper> { }
	public class AttrCreateMode : EditMode<AttrEditWrapper> { }
}
