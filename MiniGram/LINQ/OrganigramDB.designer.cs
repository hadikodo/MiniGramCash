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

namespace MiniGram.LINQ
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="OrganigramSecurity")]
	public partial class OrganigramDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTblUser(TblUser instance);
    partial void UpdateTblUser(TblUser instance);
    partial void DeleteTblUser(TblUser instance);
    #endregion
		
		public OrganigramDBDataContext() : 
				base(global::MiniGram.Properties.Settings.Default.OrganigramSecurityConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public OrganigramDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OrganigramDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OrganigramDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OrganigramDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TblUser> TblUsers
		{
			get
			{
				return this.GetTable<TblUser>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TblUsers")]
	public partial class TblUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _BatchNumber;
		
		private string _FullNameAr;
		
		private string _FullNameEn;
		
		private System.Nullable<System.DateTime> _DateOfEmployment;
		
		private string _UserName;
		
		private string _Password;
		
		private string _PIN;
		
		private string _CardNumber;
		
		private System.Nullable<System.DateTime> _LastSeen;
		
		private string _ComputerName;
		
		private System.Nullable<int> _OldSmartID;
		
		private string _PIN2;
		
		private System.Nullable<int> _BatchNumber2;
		
		private string _BloodGroup;
		
		private string _CardLableName;
		
		private string _CardQR1;
		
		private string _CardQR2;
		
		private System.Nullable<int> _OldBatchNumber;
		
		private string _PhoneNbr;
		
		private System.Data.Linq.Binary _qr1;
		
		private System.Data.Linq.Binary _qr2;
		
		private System.Nullable<int> _Sex;
		
		private string _FP;
		
		private string _FPindex;
		
		private string _Fpflag;
		
		private System.Nullable<int> _idsPID;
		
		private System.Nullable<bool> _isKafil;
		
		private System.Nullable<bool> _isDamanEnsured;
		
		private System.Nullable<bool> _isSubscribedToMedicalServices;
		
		private System.Nullable<decimal> _kafalaLimit;
		
		private string _dependentsStr;
		
		private string _medicalServicesPeopleStr;
		
		private bool _isSubscribedToWifiService;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnBatchNumberChanging(System.Nullable<int> value);
    partial void OnBatchNumberChanged();
    partial void OnFullNameArChanging(string value);
    partial void OnFullNameArChanged();
    partial void OnFullNameEnChanging(string value);
    partial void OnFullNameEnChanged();
    partial void OnDateOfEmploymentChanging(System.Nullable<System.DateTime> value);
    partial void OnDateOfEmploymentChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnPINChanging(string value);
    partial void OnPINChanged();
    partial void OnCardNumberChanging(string value);
    partial void OnCardNumberChanged();
    partial void OnLastSeenChanging(System.Nullable<System.DateTime> value);
    partial void OnLastSeenChanged();
    partial void OnComputerNameChanging(string value);
    partial void OnComputerNameChanged();
    partial void OnOldSmartIDChanging(System.Nullable<int> value);
    partial void OnOldSmartIDChanged();
    partial void OnPIN2Changing(string value);
    partial void OnPIN2Changed();
    partial void OnBatchNumber2Changing(System.Nullable<int> value);
    partial void OnBatchNumber2Changed();
    partial void OnBloodGroupChanging(string value);
    partial void OnBloodGroupChanged();
    partial void OnCardLableNameChanging(string value);
    partial void OnCardLableNameChanged();
    partial void OnCardQR1Changing(string value);
    partial void OnCardQR1Changed();
    partial void OnCardQR2Changing(string value);
    partial void OnCardQR2Changed();
    partial void OnOldBatchNumberChanging(System.Nullable<int> value);
    partial void OnOldBatchNumberChanged();
    partial void OnPhoneNbrChanging(string value);
    partial void OnPhoneNbrChanged();
    partial void Onqr1Changing(System.Data.Linq.Binary value);
    partial void Onqr1Changed();
    partial void Onqr2Changing(System.Data.Linq.Binary value);
    partial void Onqr2Changed();
    partial void OnSexChanging(System.Nullable<int> value);
    partial void OnSexChanged();
    partial void OnFPChanging(string value);
    partial void OnFPChanged();
    partial void OnFPindexChanging(string value);
    partial void OnFPindexChanged();
    partial void OnFpflagChanging(string value);
    partial void OnFpflagChanged();
    partial void OnidsPIDChanging(System.Nullable<int> value);
    partial void OnidsPIDChanged();
    partial void OnisKafilChanging(System.Nullable<bool> value);
    partial void OnisKafilChanged();
    partial void OnisDamanEnsuredChanging(System.Nullable<bool> value);
    partial void OnisDamanEnsuredChanged();
    partial void OnisSubscribedToMedicalServicesChanging(System.Nullable<bool> value);
    partial void OnisSubscribedToMedicalServicesChanged();
    partial void OnkafalaLimitChanging(System.Nullable<decimal> value);
    partial void OnkafalaLimitChanged();
    partial void OndependentsStrChanging(string value);
    partial void OndependentsStrChanged();
    partial void OnmedicalServicesPeopleStrChanging(string value);
    partial void OnmedicalServicesPeopleStrChanged();
    partial void OnisSubscribedToWifiServiceChanging(bool value);
    partial void OnisSubscribedToWifiServiceChanged();
    #endregion
		
		public TblUser()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BatchNumber", DbType="Int")]
		public System.Nullable<int> BatchNumber
		{
			get
			{
				return this._BatchNumber;
			}
			set
			{
				if ((this._BatchNumber != value))
				{
					this.OnBatchNumberChanging(value);
					this.SendPropertyChanging();
					this._BatchNumber = value;
					this.SendPropertyChanged("BatchNumber");
					this.OnBatchNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullNameAr", DbType="NVarChar(50)")]
		public string FullNameAr
		{
			get
			{
				return this._FullNameAr;
			}
			set
			{
				if ((this._FullNameAr != value))
				{
					this.OnFullNameArChanging(value);
					this.SendPropertyChanging();
					this._FullNameAr = value;
					this.SendPropertyChanged("FullNameAr");
					this.OnFullNameArChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullNameEn", DbType="VarChar(50)")]
		public string FullNameEn
		{
			get
			{
				return this._FullNameEn;
			}
			set
			{
				if ((this._FullNameEn != value))
				{
					this.OnFullNameEnChanging(value);
					this.SendPropertyChanging();
					this._FullNameEn = value;
					this.SendPropertyChanged("FullNameEn");
					this.OnFullNameEnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfEmployment", DbType="Date")]
		public System.Nullable<System.DateTime> DateOfEmployment
		{
			get
			{
				return this._DateOfEmployment;
			}
			set
			{
				if ((this._DateOfEmployment != value))
				{
					this.OnDateOfEmploymentChanging(value);
					this.SendPropertyChanging();
					this._DateOfEmployment = value;
					this.SendPropertyChanged("DateOfEmployment");
					this.OnDateOfEmploymentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(15)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(15)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PIN", DbType="NVarChar(15)")]
		public string PIN
		{
			get
			{
				return this._PIN;
			}
			set
			{
				if ((this._PIN != value))
				{
					this.OnPINChanging(value);
					this.SendPropertyChanging();
					this._PIN = value;
					this.SendPropertyChanged("PIN");
					this.OnPINChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CardNumber", DbType="NVarChar(12)")]
		public string CardNumber
		{
			get
			{
				return this._CardNumber;
			}
			set
			{
				if ((this._CardNumber != value))
				{
					this.OnCardNumberChanging(value);
					this.SendPropertyChanging();
					this._CardNumber = value;
					this.SendPropertyChanged("CardNumber");
					this.OnCardNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastSeen", DbType="DateTime")]
		public System.Nullable<System.DateTime> LastSeen
		{
			get
			{
				return this._LastSeen;
			}
			set
			{
				if ((this._LastSeen != value))
				{
					this.OnLastSeenChanging(value);
					this.SendPropertyChanging();
					this._LastSeen = value;
					this.SendPropertyChanged("LastSeen");
					this.OnLastSeenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ComputerName", DbType="NVarChar(100)")]
		public string ComputerName
		{
			get
			{
				return this._ComputerName;
			}
			set
			{
				if ((this._ComputerName != value))
				{
					this.OnComputerNameChanging(value);
					this.SendPropertyChanging();
					this._ComputerName = value;
					this.SendPropertyChanged("ComputerName");
					this.OnComputerNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OldSmartID", DbType="Int")]
		public System.Nullable<int> OldSmartID
		{
			get
			{
				return this._OldSmartID;
			}
			set
			{
				if ((this._OldSmartID != value))
				{
					this.OnOldSmartIDChanging(value);
					this.SendPropertyChanging();
					this._OldSmartID = value;
					this.SendPropertyChanged("OldSmartID");
					this.OnOldSmartIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PIN2", DbType="NVarChar(15)")]
		public string PIN2
		{
			get
			{
				return this._PIN2;
			}
			set
			{
				if ((this._PIN2 != value))
				{
					this.OnPIN2Changing(value);
					this.SendPropertyChanging();
					this._PIN2 = value;
					this.SendPropertyChanged("PIN2");
					this.OnPIN2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BatchNumber2", DbType="Int")]
		public System.Nullable<int> BatchNumber2
		{
			get
			{
				return this._BatchNumber2;
			}
			set
			{
				if ((this._BatchNumber2 != value))
				{
					this.OnBatchNumber2Changing(value);
					this.SendPropertyChanging();
					this._BatchNumber2 = value;
					this.SendPropertyChanged("BatchNumber2");
					this.OnBatchNumber2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BloodGroup", DbType="NVarChar(10)")]
		public string BloodGroup
		{
			get
			{
				return this._BloodGroup;
			}
			set
			{
				if ((this._BloodGroup != value))
				{
					this.OnBloodGroupChanging(value);
					this.SendPropertyChanging();
					this._BloodGroup = value;
					this.SendPropertyChanged("BloodGroup");
					this.OnBloodGroupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CardLableName", DbType="NVarChar(50)")]
		public string CardLableName
		{
			get
			{
				return this._CardLableName;
			}
			set
			{
				if ((this._CardLableName != value))
				{
					this.OnCardLableNameChanging(value);
					this.SendPropertyChanging();
					this._CardLableName = value;
					this.SendPropertyChanged("CardLableName");
					this.OnCardLableNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CardQR1", DbType="NVarChar(250)")]
		public string CardQR1
		{
			get
			{
				return this._CardQR1;
			}
			set
			{
				if ((this._CardQR1 != value))
				{
					this.OnCardQR1Changing(value);
					this.SendPropertyChanging();
					this._CardQR1 = value;
					this.SendPropertyChanged("CardQR1");
					this.OnCardQR1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CardQR2", DbType="NVarChar(250)")]
		public string CardQR2
		{
			get
			{
				return this._CardQR2;
			}
			set
			{
				if ((this._CardQR2 != value))
				{
					this.OnCardQR2Changing(value);
					this.SendPropertyChanging();
					this._CardQR2 = value;
					this.SendPropertyChanged("CardQR2");
					this.OnCardQR2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OldBatchNumber", DbType="Int")]
		public System.Nullable<int> OldBatchNumber
		{
			get
			{
				return this._OldBatchNumber;
			}
			set
			{
				if ((this._OldBatchNumber != value))
				{
					this.OnOldBatchNumberChanging(value);
					this.SendPropertyChanging();
					this._OldBatchNumber = value;
					this.SendPropertyChanged("OldBatchNumber");
					this.OnOldBatchNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNbr", DbType="NVarChar(50)")]
		public string PhoneNbr
		{
			get
			{
				return this._PhoneNbr;
			}
			set
			{
				if ((this._PhoneNbr != value))
				{
					this.OnPhoneNbrChanging(value);
					this.SendPropertyChanging();
					this._PhoneNbr = value;
					this.SendPropertyChanged("PhoneNbr");
					this.OnPhoneNbrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_qr1", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary qr1
		{
			get
			{
				return this._qr1;
			}
			set
			{
				if ((this._qr1 != value))
				{
					this.Onqr1Changing(value);
					this.SendPropertyChanging();
					this._qr1 = value;
					this.SendPropertyChanged("qr1");
					this.Onqr1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_qr2", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary qr2
		{
			get
			{
				return this._qr2;
			}
			set
			{
				if ((this._qr2 != value))
				{
					this.Onqr2Changing(value);
					this.SendPropertyChanging();
					this._qr2 = value;
					this.SendPropertyChanged("qr2");
					this.Onqr2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sex", DbType="Int")]
		public System.Nullable<int> Sex
		{
			get
			{
				return this._Sex;
			}
			set
			{
				if ((this._Sex != value))
				{
					this.OnSexChanging(value);
					this.SendPropertyChanging();
					this._Sex = value;
					this.SendPropertyChanged("Sex");
					this.OnSexChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FP", DbType="NVarChar(MAX)")]
		public string FP
		{
			get
			{
				return this._FP;
			}
			set
			{
				if ((this._FP != value))
				{
					this.OnFPChanging(value);
					this.SendPropertyChanging();
					this._FP = value;
					this.SendPropertyChanged("FP");
					this.OnFPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FPindex", DbType="NVarChar(50)")]
		public string FPindex
		{
			get
			{
				return this._FPindex;
			}
			set
			{
				if ((this._FPindex != value))
				{
					this.OnFPindexChanging(value);
					this.SendPropertyChanging();
					this._FPindex = value;
					this.SendPropertyChanged("FPindex");
					this.OnFPindexChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fpflag", DbType="NVarChar(50)")]
		public string Fpflag
		{
			get
			{
				return this._Fpflag;
			}
			set
			{
				if ((this._Fpflag != value))
				{
					this.OnFpflagChanging(value);
					this.SendPropertyChanging();
					this._Fpflag = value;
					this.SendPropertyChanged("Fpflag");
					this.OnFpflagChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idsPID", DbType="Int")]
		public System.Nullable<int> idsPID
		{
			get
			{
				return this._idsPID;
			}
			set
			{
				if ((this._idsPID != value))
				{
					this.OnidsPIDChanging(value);
					this.SendPropertyChanging();
					this._idsPID = value;
					this.SendPropertyChanged("idsPID");
					this.OnidsPIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isKafil", DbType="Bit")]
		public System.Nullable<bool> isKafil
		{
			get
			{
				return this._isKafil;
			}
			set
			{
				if ((this._isKafil != value))
				{
					this.OnisKafilChanging(value);
					this.SendPropertyChanging();
					this._isKafil = value;
					this.SendPropertyChanged("isKafil");
					this.OnisKafilChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isDamanEnsured", DbType="Bit")]
		public System.Nullable<bool> isDamanEnsured
		{
			get
			{
				return this._isDamanEnsured;
			}
			set
			{
				if ((this._isDamanEnsured != value))
				{
					this.OnisDamanEnsuredChanging(value);
					this.SendPropertyChanging();
					this._isDamanEnsured = value;
					this.SendPropertyChanged("isDamanEnsured");
					this.OnisDamanEnsuredChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isSubscribedToMedicalServices", DbType="Bit")]
		public System.Nullable<bool> isSubscribedToMedicalServices
		{
			get
			{
				return this._isSubscribedToMedicalServices;
			}
			set
			{
				if ((this._isSubscribedToMedicalServices != value))
				{
					this.OnisSubscribedToMedicalServicesChanging(value);
					this.SendPropertyChanging();
					this._isSubscribedToMedicalServices = value;
					this.SendPropertyChanged("isSubscribedToMedicalServices");
					this.OnisSubscribedToMedicalServicesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kafalaLimit", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> kafalaLimit
		{
			get
			{
				return this._kafalaLimit;
			}
			set
			{
				if ((this._kafalaLimit != value))
				{
					this.OnkafalaLimitChanging(value);
					this.SendPropertyChanging();
					this._kafalaLimit = value;
					this.SendPropertyChanged("kafalaLimit");
					this.OnkafalaLimitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dependentsStr", DbType="NVarChar(MAX)")]
		public string dependentsStr
		{
			get
			{
				return this._dependentsStr;
			}
			set
			{
				if ((this._dependentsStr != value))
				{
					this.OndependentsStrChanging(value);
					this.SendPropertyChanging();
					this._dependentsStr = value;
					this.SendPropertyChanged("dependentsStr");
					this.OndependentsStrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_medicalServicesPeopleStr", DbType="NVarChar(MAX)")]
		public string medicalServicesPeopleStr
		{
			get
			{
				return this._medicalServicesPeopleStr;
			}
			set
			{
				if ((this._medicalServicesPeopleStr != value))
				{
					this.OnmedicalServicesPeopleStrChanging(value);
					this.SendPropertyChanging();
					this._medicalServicesPeopleStr = value;
					this.SendPropertyChanged("medicalServicesPeopleStr");
					this.OnmedicalServicesPeopleStrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isSubscribedToWifiService", DbType="Bit NOT NULL")]
		public bool isSubscribedToWifiService
		{
			get
			{
				return this._isSubscribedToWifiService;
			}
			set
			{
				if ((this._isSubscribedToWifiService != value))
				{
					this.OnisSubscribedToWifiServiceChanging(value);
					this.SendPropertyChanging();
					this._isSubscribedToWifiService = value;
					this.SendPropertyChanged("isSubscribedToWifiService");
					this.OnisSubscribedToWifiServiceChanged();
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
}
#pragma warning restore 1591
