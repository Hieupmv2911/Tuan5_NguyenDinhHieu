﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Buoi4_NguyenDinhHieu.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="NhaSach")]
	public partial class MyDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSach1(Sach1 instance);
    partial void UpdateSach1(Sach1 instance);
    partial void DeleteSach1(Sach1 instance);
    partial void InsertTheLoai1(TheLoai1 instance);
    partial void UpdateTheLoai1(TheLoai1 instance);
    partial void DeleteTheLoai1(TheLoai1 instance);
    #endregion
		
		public MyDataDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["NhaSachConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Sach1> Sach1s
		{
			get
			{
				return this.GetTable<Sach1>();
			}
		}
		
		public System.Data.Linq.Table<TheLoai1> TheLoai1s
		{
			get
			{
				return this.GetTable<TheLoai1>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sach1")]
	public partial class Sach1 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _masach;
		
		private System.Nullable<int> _maloai;
		
		private string _tensach;
		
		private string _hinh;
		
		private System.Nullable<decimal> _giaban;
		
		private System.Nullable<System.DateTime> _ngaycapnhat;
		
		private System.Nullable<int> _soluongton;
		
		private EntityRef<TheLoai1> _TheLoai1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmasachChanging(int value);
    partial void OnmasachChanged();
    partial void OnmaloaiChanging(System.Nullable<int> value);
    partial void OnmaloaiChanged();
    partial void OntensachChanging(string value);
    partial void OntensachChanged();
    partial void OnhinhChanging(string value);
    partial void OnhinhChanged();
    partial void OngiabanChanging(System.Nullable<decimal> value);
    partial void OngiabanChanged();
    partial void OnngaycapnhatChanging(System.Nullable<System.DateTime> value);
    partial void OnngaycapnhatChanged();
    partial void OnsoluongtonChanging(System.Nullable<int> value);
    partial void OnsoluongtonChanged();
    #endregion
		
		public Sach1()
		{
			this._TheLoai1 = default(EntityRef<TheLoai1>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_masach", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int masach
		{
			get
			{
				return this._masach;
			}
			set
			{
				if ((this._masach != value))
				{
					this.OnmasachChanging(value);
					this.SendPropertyChanging();
					this._masach = value;
					this.SendPropertyChanged("masach");
					this.OnmasachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maloai", DbType="Int")]
		public System.Nullable<int> maloai
		{
			get
			{
				return this._maloai;
			}
			set
			{
				if ((this._maloai != value))
				{
					if (this._TheLoai1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaloaiChanging(value);
					this.SendPropertyChanging();
					this._maloai = value;
					this.SendPropertyChanged("maloai");
					this.OnmaloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tensach", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string tensach
		{
			get
			{
				return this._tensach;
			}
			set
			{
				if ((this._tensach != value))
				{
					this.OntensachChanging(value);
					this.SendPropertyChanging();
					this._tensach = value;
					this.SendPropertyChanged("tensach");
					this.OntensachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hinh", DbType="VarChar(50)")]
		public string hinh
		{
			get
			{
				return this._hinh;
			}
			set
			{
				if ((this._hinh != value))
				{
					this.OnhinhChanging(value);
					this.SendPropertyChanging();
					this._hinh = value;
					this.SendPropertyChanged("hinh");
					this.OnhinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_giaban", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> giaban
		{
			get
			{
				return this._giaban;
			}
			set
			{
				if ((this._giaban != value))
				{
					this.OngiabanChanging(value);
					this.SendPropertyChanging();
					this._giaban = value;
					this.SendPropertyChanged("giaban");
					this.OngiabanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaycapnhat", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> ngaycapnhat
		{
			get
			{
				return this._ngaycapnhat;
			}
			set
			{
				if ((this._ngaycapnhat != value))
				{
					this.OnngaycapnhatChanging(value);
					this.SendPropertyChanging();
					this._ngaycapnhat = value;
					this.SendPropertyChanged("ngaycapnhat");
					this.OnngaycapnhatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soluongton", DbType="Int")]
		public System.Nullable<int> soluongton
		{
			get
			{
				return this._soluongton;
			}
			set
			{
				if ((this._soluongton != value))
				{
					this.OnsoluongtonChanging(value);
					this.SendPropertyChanging();
					this._soluongton = value;
					this.SendPropertyChanged("soluongton");
					this.OnsoluongtonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TheLoai1_Sach1", Storage="_TheLoai1", ThisKey="maloai", OtherKey="maloai", IsForeignKey=true)]
		public TheLoai1 TheLoai1
		{
			get
			{
				return this._TheLoai1.Entity;
			}
			set
			{
				TheLoai1 previousValue = this._TheLoai1.Entity;
				if (((previousValue != value) 
							|| (this._TheLoai1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TheLoai1.Entity = null;
						previousValue.Sach1s.Remove(this);
					}
					this._TheLoai1.Entity = value;
					if ((value != null))
					{
						value.Sach1s.Add(this);
						this._maloai = value.maloai;
					}
					else
					{
						this._maloai = default(Nullable<int>);
					}
					this.SendPropertyChanged("TheLoai1");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TheLoai1")]
	public partial class TheLoai1 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _maloai;
		
		private string _tenloai;
		
		private EntitySet<Sach1> _Sach1s;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaloaiChanging(int value);
    partial void OnmaloaiChanged();
    partial void OntenloaiChanging(string value);
    partial void OntenloaiChanged();
    #endregion
		
		public TheLoai1()
		{
			this._Sach1s = new EntitySet<Sach1>(new Action<Sach1>(this.attach_Sach1s), new Action<Sach1>(this.detach_Sach1s));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maloai", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int maloai
		{
			get
			{
				return this._maloai;
			}
			set
			{
				if ((this._maloai != value))
				{
					this.OnmaloaiChanging(value);
					this.SendPropertyChanging();
					this._maloai = value;
					this.SendPropertyChanged("maloai");
					this.OnmaloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenloai", DbType="NVarChar(30)")]
		public string tenloai
		{
			get
			{
				return this._tenloai;
			}
			set
			{
				if ((this._tenloai != value))
				{
					this.OntenloaiChanging(value);
					this.SendPropertyChanging();
					this._tenloai = value;
					this.SendPropertyChanged("tenloai");
					this.OntenloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TheLoai1_Sach1", Storage="_Sach1s", ThisKey="maloai", OtherKey="maloai")]
		public EntitySet<Sach1> Sach1s
		{
			get
			{
				return this._Sach1s;
			}
			set
			{
				this._Sach1s.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Sach1s(Sach1 entity)
		{
			this.SendPropertyChanging();
			entity.TheLoai1 = this;
		}
		
		private void detach_Sach1s(Sach1 entity)
		{
			this.SendPropertyChanging();
			entity.TheLoai1 = null;
		}
	}
}
#pragma warning restore 1591
