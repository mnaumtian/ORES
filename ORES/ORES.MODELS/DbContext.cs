namespace ORES_MODELS
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
	
	
	public partial class ORES : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
        #region Extensibility Method Definitions
        partial void OnCreated();
        partial void InsertActivityLog(ActivityLog instance);
        partial void UpdateActivityLog(ActivityLog instance);
        partial void DeleteActivityLog(ActivityLog instance);
        partial void InsertAnswerType(AnswerType instance);
        partial void UpdateAnswerType(AnswerType instance);
        partial void DeleteAnswerType(AnswerType instance);
        partial void InsertEvaluation(Evaluation instance);
        partial void UpdateEvaluation(Evaluation instance);
        partial void DeleteEvaluation(Evaluation instance);
        partial void InsertEvaluationManagement(EvaluationManagement instance);
        partial void UpdateEvaluationManagement(EvaluationManagement instance);
        partial void DeleteEvaluationManagement(EvaluationManagement instance);
        partial void InsertEvaluationResult(EvaluationResult instance);
        partial void UpdateEvaluationResult(EvaluationResult instance);
        partial void DeleteEvaluationResult(EvaluationResult instance);
        partial void InsertExceptions(Exceptions instance);
        partial void UpdateExceptions(Exceptions instance);
        partial void DeleteExceptions(Exceptions instance);
        partial void InsertForms(Forms instance);
        partial void UpdateForms(Forms instance);
        partial void DeleteForms(Forms instance);
        partial void InsertGroup(Group instance);
        partial void UpdateGroup(Group instance);
        partial void DeleteGroup(Group instance);
        partial void InsertGroupMember(GroupMember instance);
        partial void UpdateGroupMember(GroupMember instance);
        partial void DeleteGroupMember(GroupMember instance);
        partial void InsertMailConfiguration(MailConfiguration instance);
        partial void UpdateMailConfiguration(MailConfiguration instance);
        partial void DeleteMailConfiguration(MailConfiguration instance);
        partial void InsertMailScheduling(MailScheduling instance);
        partial void UpdateMailScheduling(MailScheduling instance);
        partial void DeleteMailScheduling(MailScheduling instance);
        partial void InsertQuestions(Questions instance);
        partial void UpdateQuestions(Questions instance);
        partial void DeleteQuestions(Questions instance);
        partial void InsertRole(Role instance);
        partial void UpdateRole(Role instance);
        partial void DeleteRole(Role instance);
        partial void InsertRolesRightsManagement(RolesRightsManagement instance);
        partial void UpdateRolesRightsManagement(RolesRightsManagement instance);
        partial void DeleteRolesRightsManagement(RolesRightsManagement instance);
        partial void InsertUser(User instance);
        partial void UpdateUser(User instance);
        partial void DeleteUser(User instance);
        #endregion
		
		public ORES(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ORES(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ORES(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ORES(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ActivityLog> ActivityLog
		{
			get
			{
				return this.GetTable<ActivityLog>();
			}
		}
		
		public System.Data.Linq.Table<AnswerType> AnswerType
		{
			get
			{
				return this.GetTable<AnswerType>();
			}
		}
		
		public System.Data.Linq.Table<Evaluation> Evaluation
		{
			get
			{
				return this.GetTable<Evaluation>();
			}
		}
		
		public System.Data.Linq.Table<EvaluationManagement> EvaluationManagement
		{
			get
			{
				return this.GetTable<EvaluationManagement>();
			}
		}
		
		public System.Data.Linq.Table<EvaluationResult> EvaluationResult
		{
			get
			{
				return this.GetTable<EvaluationResult>();
			}
		}
		
		public System.Data.Linq.Table<Exceptions> Exceptions
		{
			get
			{
				return this.GetTable<Exceptions>();
			}
		}
		
		public System.Data.Linq.Table<Forms> Forms
		{
			get
			{
				return this.GetTable<Forms>();
			}
		}
		
		public System.Data.Linq.Table<Group> Group
		{
			get
			{
				return this.GetTable<Group>();
			}
		}
		
		public System.Data.Linq.Table<GroupMember> GroupMember
		{
			get
			{
				return this.GetTable<GroupMember>();
			}
		}
		
		public System.Data.Linq.Table<MailConfiguration> MailConfiguration
		{
			get
			{
				return this.GetTable<MailConfiguration>();
			}
		}
		
		public System.Data.Linq.Table<MailScheduling> MailScheduling
		{
			get
			{
				return this.GetTable<MailScheduling>();
			}
		}
		
		public System.Data.Linq.Table<Questions> Questions
		{
			get
			{
				return this.GetTable<Questions>();
			}
		}
		
		public System.Data.Linq.Table<Role> Role
		{
			get
			{
				return this.GetTable<Role>();
			}
		}
		
		public System.Data.Linq.Table<RolesRightsManagement> RolesRightsManagement
		{
			get
			{
				return this.GetTable<RolesRightsManagement>();
			}
		}
		
		public System.Data.Linq.Table<User> User
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[Table(Name="dbo.ActivityLog")]
	public partial class ActivityLog : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ActivityLogId;
		
		private string _ActivityName;
		
		private string _FormName;
		
		private int _CreatedBy;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private bool _IsDelete;
		
		private EntityRef<User> _User;
		
        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnActivityLogIdChanging(int value);
        partial void OnActivityLogIdChanged();
        partial void OnActivityNameChanging(string value);
        partial void OnActivityNameChanged();
        partial void OnFormNameChanging(string value);
        partial void OnFormNameChanged();
        partial void OnCreatedByChanging(int value);
        partial void OnCreatedByChanged();
        partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
        partial void OnCreatedOnChanged();
        partial void OnIsDeleteChanging(bool value);
        partial void OnIsDeleteChanged();
        #endregion
		
		public ActivityLog()
		{
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[Column(Storage="_ActivityLogId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ActivityLogId
		{
			get
			{
				return this._ActivityLogId;
			}
			set
			{
				if ((this._ActivityLogId != value))
				{
					this.OnActivityLogIdChanging(value);
					this.SendPropertyChanging();
					this._ActivityLogId = value;
					this.SendPropertyChanged("ActivityLogId");
					this.OnActivityLogIdChanged();
				}
			}
		}
		
		[Column(Storage="_ActivityName", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string ActivityName
		{
			get
			{
				return this._ActivityName;
			}
			set
			{
				if ((this._ActivityName != value))
				{
					this.OnActivityNameChanging(value);
					this.SendPropertyChanging();
					this._ActivityName = value;
					this.SendPropertyChanged("ActivityName");
					this.OnActivityNameChanged();
				}
			}
		}
		
		[Column(Storage="_FormName", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string FormName
		{
			get
			{
				return this._FormName;
			}
			set
			{
				if ((this._FormName != value))
				{
					this.OnFormNameChanging(value);
					this.SendPropertyChanging();
					this._FormName = value;
					this.SendPropertyChanged("FormName");
					this.OnFormNameChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedBy", DbType="Int NOT NULL")]
		public int CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[Column(Storage="_IsDelete", DbType="Bit NOT NULL")]
		public bool IsDelete
		{
			get
			{
				return this._IsDelete;
			}
			set
			{
				if ((this._IsDelete != value))
				{
					this.OnIsDeleteChanging(value);
					this.SendPropertyChanging();
					this._IsDelete = value;
					this.SendPropertyChanged("IsDelete");
					this.OnIsDeleteChanged();
				}
			}
		}
		
		[Association(Name="FK_ActivityLog_User", Storage="_User", ThisKey="CreatedBy", OtherKey="UserId", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.ActivityLog.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.ActivityLog.Add(this);
						this._CreatedBy = value.UserId;
					}
					else
					{
						this._CreatedBy = default(int);
					}
					this.SendPropertyChanged("User");
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
	
	[Table(Name="dbo.AnswerType")]
	public partial class AnswerType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AnswerTypeId;
		
		private string _AnswerType1;
		
		private string _CreatedBy;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private string _ModifiedBy;
		
		private System.DateTime _ModifiedOn;
		
		private bool _IsDelete;
		
		private EntitySet<Questions> _Questions;
		
        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnAnswerTypeIdChanging(int value);
        partial void OnAnswerTypeIdChanged();
        partial void OnAnswerType1Changing(string value);
        partial void OnAnswerType1Changed();
        partial void OnCreatedByChanging(string value);
        partial void OnCreatedByChanged();
        partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
        partial void OnCreatedOnChanged();
        partial void OnModifiedByChanging(string value);
        partial void OnModifiedByChanged();
        partial void OnModifiedOnChanging(System.DateTime value);
        partial void OnModifiedOnChanged();
        partial void OnIsDeleteChanging(bool value);
        partial void OnIsDeleteChanged();
        #endregion
		
		public AnswerType()
		{
			this._Questions = new EntitySet<Questions>(new Action<Questions>(this.attach_Questions), new Action<Questions>(this.detach_Questions));
			OnCreated();
		}
		
		[Column(Storage="_AnswerTypeId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int AnswerTypeId
		{
			get
			{
				return this._AnswerTypeId;
			}
			set
			{
				if ((this._AnswerTypeId != value))
				{
					this.OnAnswerTypeIdChanging(value);
					this.SendPropertyChanging();
					this._AnswerTypeId = value;
					this.SendPropertyChanged("AnswerTypeId");
					this.OnAnswerTypeIdChanged();
				}
			}
		}
		
		[Column(Name="AnswerType", Storage="_AnswerType1", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string AnswerType1
		{
			get
			{
				return this._AnswerType1;
			}
			set
			{
				if ((this._AnswerType1 != value))
				{
					this.OnAnswerType1Changing(value);
					this.SendPropertyChanging();
					this._AnswerType1 = value;
					this.SendPropertyChanged("AnswerType1");
					this.OnAnswerType1Changed();
				}
			}
		}
		
		[Column(Storage="_CreatedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedOn", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this.OnModifiedOnChanging(value);
					this.SendPropertyChanging();
					this._ModifiedOn = value;
					this.SendPropertyChanged("ModifiedOn");
					this.OnModifiedOnChanged();
				}
			}
		}
		
		[Column(Storage="_IsDelete", DbType="Bit NOT NULL")]
		public bool IsDelete
		{
			get
			{
				return this._IsDelete;
			}
			set
			{
				if ((this._IsDelete != value))
				{
					this.OnIsDeleteChanging(value);
					this.SendPropertyChanging();
					this._IsDelete = value;
					this.SendPropertyChanged("IsDelete");
					this.OnIsDeleteChanged();
				}
			}
		}
		
		[Association(Name="FK_Questions_AnswerType", Storage="_Questions", ThisKey="AnswerTypeId", OtherKey="AnswerTypeId", DeleteRule="NO ACTION")]
		public EntitySet<Questions> Questions
		{
			get
			{
				return this._Questions;
			}
			set
			{
				this._Questions.Assign(value);
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
		
		private void attach_Questions(Questions entity)
		{
			this.SendPropertyChanging();
			entity.AnswerType = this;
		}
		
		private void detach_Questions(Questions entity)
		{
			this.SendPropertyChanging();
			entity.AnswerType = null;
		}
	}
	
	[Table(Name="dbo.Evaluation")]
	public partial class Evaluation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EvaluationId;
		
		private int _RevieweeId;
		
		private int _GroupId;
		
		private string _CreatedBy;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private string _ModifiedBy;
		
		private System.DateTime _ModifiedOn;
		
		private bool _IsDelete;
		
		private EntitySet<EvaluationManagement> _EvaluationManagement;
		
		private EntityRef<Group> _Group;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEvaluationIdChanging(int value);
    partial void OnEvaluationIdChanged();
    partial void OnRevieweeIdChanging(int value);
    partial void OnRevieweeIdChanged();
    partial void OnGroupIdChanging(int value);
    partial void OnGroupIdChanged();
    partial void OnCreatedByChanging(string value);
    partial void OnCreatedByChanged();
    partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnChanged();
    partial void OnModifiedByChanging(string value);
    partial void OnModifiedByChanged();
    partial void OnModifiedOnChanging(System.DateTime value);
    partial void OnModifiedOnChanged();
    partial void OnIsDeleteChanging(bool value);
    partial void OnIsDeleteChanged();
    #endregion
		
		public Evaluation()
		{
			this._EvaluationManagement = new EntitySet<EvaluationManagement>(new Action<EvaluationManagement>(this.attach_EvaluationManagement), new Action<EvaluationManagement>(this.detach_EvaluationManagement));
			this._Group = default(EntityRef<Group>);
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[Column(Storage="_EvaluationId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int EvaluationId
		{
			get
			{
				return this._EvaluationId;
			}
			set
			{
				if ((this._EvaluationId != value))
				{
					this.OnEvaluationIdChanging(value);
					this.SendPropertyChanging();
					this._EvaluationId = value;
					this.SendPropertyChanged("EvaluationId");
					this.OnEvaluationIdChanged();
				}
			}
		}
		
		[Column(Storage="_RevieweeId", DbType="Int NOT NULL")]
		public int RevieweeId
		{
			get
			{
				return this._RevieweeId;
			}
			set
			{
				if ((this._RevieweeId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRevieweeIdChanging(value);
					this.SendPropertyChanging();
					this._RevieweeId = value;
					this.SendPropertyChanged("RevieweeId");
					this.OnRevieweeIdChanged();
				}
			}
		}
		
		[Column(Storage="_GroupId", DbType="Int NOT NULL")]
		public int GroupId
		{
			get
			{
				return this._GroupId;
			}
			set
			{
				if ((this._GroupId != value))
				{
					if (this._Group.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGroupIdChanging(value);
					this.SendPropertyChanging();
					this._GroupId = value;
					this.SendPropertyChanged("GroupId");
					this.OnGroupIdChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedOn", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this.OnModifiedOnChanging(value);
					this.SendPropertyChanging();
					this._ModifiedOn = value;
					this.SendPropertyChanged("ModifiedOn");
					this.OnModifiedOnChanged();
				}
			}
		}
		
		[Column(Storage="_IsDelete", DbType="Bit NOT NULL")]
		public bool IsDelete
		{
			get
			{
				return this._IsDelete;
			}
			set
			{
				if ((this._IsDelete != value))
				{
					this.OnIsDeleteChanging(value);
					this.SendPropertyChanging();
					this._IsDelete = value;
					this.SendPropertyChanged("IsDelete");
					this.OnIsDeleteChanged();
				}
			}
		}
		
		[Association(Name="FK_EVALUATIONMGMT_EVALUATION", Storage="_EvaluationManagement", ThisKey="EvaluationId", OtherKey="EvaluationId", DeleteRule="NO ACTION")]
		public EntitySet<EvaluationManagement> EvaluationManagement
		{
			get
			{
				return this._EvaluationManagement;
			}
			set
			{
				this._EvaluationManagement.Assign(value);
			}
		}
		
		[Association(Name="FK_Survey_Group", Storage="_Group", ThisKey="GroupId", OtherKey="GroupId", IsForeignKey=true)]
		public Group Group
		{
			get
			{
				return this._Group.Entity;
			}
			set
			{
				Group previousValue = this._Group.Entity;
				if (((previousValue != value) 
							|| (this._Group.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Group.Entity = null;
						previousValue.Evaluation.Remove(this);
					}
					this._Group.Entity = value;
					if ((value != null))
					{
						value.Evaluation.Add(this);
						this._GroupId = value.GroupId;
					}
					else
					{
						this._GroupId = default(int);
					}
					this.SendPropertyChanged("Group");
				}
			}
		}
		
		[Association(Name="FK_Survey_User", Storage="_User", ThisKey="RevieweeId", OtherKey="UserId", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Evaluation.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Evaluation.Add(this);
						this._RevieweeId = value.UserId;
					}
					else
					{
						this._RevieweeId = default(int);
					}
					this.SendPropertyChanged("User");
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
		
		private void attach_EvaluationManagement(EvaluationManagement entity)
		{
			this.SendPropertyChanging();
			entity.Evaluation = this;
		}
		
		private void detach_EvaluationManagement(EvaluationManagement entity)
		{
			this.SendPropertyChanging();
			entity.Evaluation = null;
		}
	}
	
	[Table(Name="dbo.EvaluationManagement")]
	public partial class EvaluationManagement : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EvaluationManagementId;
		
		private int _EvaluationId;
		
		private bool _IsCompulsory;
		
		private System.Nullable<System.DateTime> _ExpiryDate;
		
		private string _CreatedBy;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private string _ModifiedBy;
		
		private System.DateTime _ModifiedOn;
		
		private bool _IsDelete;
		
		private int _QuestionId;
		
		private EntityRef<Evaluation> _Evaluation;
		
		private EntityRef<Questions> _Questions;
		
		private EntitySet<EvaluationResult> _EvaluationResult;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEvaluationManagementIdChanging(int value);
    partial void OnEvaluationManagementIdChanged();
    partial void OnEvaluationIdChanging(int value);
    partial void OnEvaluationIdChanged();
    partial void OnIsCompulsoryChanging(bool value);
    partial void OnIsCompulsoryChanged();
    partial void OnExpiryDateChanging(System.Nullable<System.DateTime> value);
    partial void OnExpiryDateChanged();
    partial void OnCreatedByChanging(string value);
    partial void OnCreatedByChanged();
    partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnChanged();
    partial void OnModifiedByChanging(string value);
    partial void OnModifiedByChanged();
    partial void OnModifiedOnChanging(System.DateTime value);
    partial void OnModifiedOnChanged();
    partial void OnIsDeleteChanging(bool value);
    partial void OnIsDeleteChanged();
    partial void OnQuestionIdChanging(int value);
    partial void OnQuestionIdChanged();
    #endregion
		
		public EvaluationManagement()
		{
			this._Evaluation = default(EntityRef<Evaluation>);
			this._Questions = default(EntityRef<Questions>);
			this._EvaluationResult = new EntitySet<EvaluationResult>(new Action<EvaluationResult>(this.attach_EvaluationResult), new Action<EvaluationResult>(this.detach_EvaluationResult));
			OnCreated();
		}
		
		[Column(Storage="_EvaluationManagementId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int EvaluationManagementId
		{
			get
			{
				return this._EvaluationManagementId;
			}
			set
			{
				if ((this._EvaluationManagementId != value))
				{
					this.OnEvaluationManagementIdChanging(value);
					this.SendPropertyChanging();
					this._EvaluationManagementId = value;
					this.SendPropertyChanged("EvaluationManagementId");
					this.OnEvaluationManagementIdChanged();
				}
			}
		}
		
		[Column(Storage="_EvaluationId", DbType="Int NOT NULL")]
		public int EvaluationId
		{
			get
			{
				return this._EvaluationId;
			}
			set
			{
				if ((this._EvaluationId != value))
				{
					if (this._Evaluation.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEvaluationIdChanging(value);
					this.SendPropertyChanging();
					this._EvaluationId = value;
					this.SendPropertyChanged("EvaluationId");
					this.OnEvaluationIdChanged();
				}
			}
		}
		
		[Column(Storage="_IsCompulsory", DbType="Bit NOT NULL")]
		public bool IsCompulsory
		{
			get
			{
				return this._IsCompulsory;
			}
			set
			{
				if ((this._IsCompulsory != value))
				{
					this.OnIsCompulsoryChanging(value);
					this.SendPropertyChanging();
					this._IsCompulsory = value;
					this.SendPropertyChanged("IsCompulsory");
					this.OnIsCompulsoryChanged();
				}
			}
		}
		
		[Column(Storage="_ExpiryDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> ExpiryDate
		{
			get
			{
				return this._ExpiryDate;
			}
			set
			{
				if ((this._ExpiryDate != value))
				{
					this.OnExpiryDateChanging(value);
					this.SendPropertyChanging();
					this._ExpiryDate = value;
					this.SendPropertyChanged("ExpiryDate");
					this.OnExpiryDateChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedOn", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this.OnModifiedOnChanging(value);
					this.SendPropertyChanging();
					this._ModifiedOn = value;
					this.SendPropertyChanged("ModifiedOn");
					this.OnModifiedOnChanged();
				}
			}
		}
		
		[Column(Storage="_IsDelete", DbType="Bit NOT NULL")]
		public bool IsDelete
		{
			get
			{
				return this._IsDelete;
			}
			set
			{
				if ((this._IsDelete != value))
				{
					this.OnIsDeleteChanging(value);
					this.SendPropertyChanging();
					this._IsDelete = value;
					this.SendPropertyChanged("IsDelete");
					this.OnIsDeleteChanged();
				}
			}
		}
		
		[Column(Storage="_QuestionId", DbType="Int NOT NULL")]
		public int QuestionId
		{
			get
			{
				return this._QuestionId;
			}
			set
			{
				if ((this._QuestionId != value))
				{
					if (this._Questions.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnQuestionIdChanging(value);
					this.SendPropertyChanging();
					this._QuestionId = value;
					this.SendPropertyChanged("QuestionId");
					this.OnQuestionIdChanged();
				}
			}
		}
		
		[Association(Name="FK_EVALUATIONMGMT_EVALUATION", Storage="_Evaluation", ThisKey="EvaluationId", OtherKey="EvaluationId", IsForeignKey=true)]
		public Evaluation Evaluation
		{
			get
			{
				return this._Evaluation.Entity;
			}
			set
			{
				Evaluation previousValue = this._Evaluation.Entity;
				if (((previousValue != value) 
							|| (this._Evaluation.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Evaluation.Entity = null;
						previousValue.EvaluationManagement.Remove(this);
					}
					this._Evaluation.Entity = value;
					if ((value != null))
					{
						value.EvaluationManagement.Add(this);
						this._EvaluationId = value.EvaluationId;
					}
					else
					{
						this._EvaluationId = default(int);
					}
					this.SendPropertyChanged("Evaluation");
				}
			}
		}
		
		[Association(Name="FK_EVALUATIONMGMT_QUESTION", Storage="_Questions", ThisKey="QuestionId", OtherKey="QuestionId", IsForeignKey=true)]
		public Questions Questions
		{
			get
			{
				return this._Questions.Entity;
			}
			set
			{
				Questions previousValue = this._Questions.Entity;
				if (((previousValue != value) 
							|| (this._Questions.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Questions.Entity = null;
						previousValue.EvaluationManagement.Remove(this);
					}
					this._Questions.Entity = value;
					if ((value != null))
					{
						value.EvaluationManagement.Add(this);
						this._QuestionId = value.QuestionId;
					}
					else
					{
						this._QuestionId = default(int);
					}
					this.SendPropertyChanged("Questions");
				}
			}
		}
		
		[Association(Name="FK_SurveyResult_SurveyManagement", Storage="_EvaluationResult", ThisKey="EvaluationManagementId", OtherKey="EvaluationManagementId", DeleteRule="NO ACTION")]
		public EntitySet<EvaluationResult> EvaluationResult
		{
			get
			{
				return this._EvaluationResult;
			}
			set
			{
				this._EvaluationResult.Assign(value);
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
		
		private void attach_EvaluationResult(EvaluationResult entity)
		{
			this.SendPropertyChanging();
			entity.EvaluationManagement = this;
		}
		
		private void detach_EvaluationResult(EvaluationResult entity)
		{
			this.SendPropertyChanging();
			entity.EvaluationManagement = null;
		}
	}
	
	[Table(Name="dbo.EvaluationResult")]
	public partial class EvaluationResult : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EvaluationResultId;
		
		private int _EvaluationManagementId;
		
		private int _QuestionId;
		
		private string _Answer;
		
		private string _CreatedBy;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private string _ModifiedBy;
		
		private System.DateTime _ModifiedOn;
		
		private bool _IsDelete;
		
		private EntityRef<Questions> _Questions;
		
		private EntityRef<EvaluationManagement> _EvaluationManagement;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEvaluationResultIdChanging(int value);
    partial void OnEvaluationResultIdChanged();
    partial void OnEvaluationManagementIdChanging(int value);
    partial void OnEvaluationManagementIdChanged();
    partial void OnQuestionIdChanging(int value);
    partial void OnQuestionIdChanged();
    partial void OnAnswerChanging(string value);
    partial void OnAnswerChanged();
    partial void OnCreatedByChanging(string value);
    partial void OnCreatedByChanged();
    partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnChanged();
    partial void OnModifiedByChanging(string value);
    partial void OnModifiedByChanged();
    partial void OnModifiedOnChanging(System.DateTime value);
    partial void OnModifiedOnChanged();
    partial void OnIsDeleteChanging(bool value);
    partial void OnIsDeleteChanged();
    #endregion
		
		public EvaluationResult()
		{
			this._Questions = default(EntityRef<Questions>);
			this._EvaluationManagement = default(EntityRef<EvaluationManagement>);
			OnCreated();
		}
		
		[Column(Storage="_EvaluationResultId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int EvaluationResultId
		{
			get
			{
				return this._EvaluationResultId;
			}
			set
			{
				if ((this._EvaluationResultId != value))
				{
					this.OnEvaluationResultIdChanging(value);
					this.SendPropertyChanging();
					this._EvaluationResultId = value;
					this.SendPropertyChanged("EvaluationResultId");
					this.OnEvaluationResultIdChanged();
				}
			}
		}
		
		[Column(Storage="_EvaluationManagementId", DbType="Int NOT NULL")]
		public int EvaluationManagementId
		{
			get
			{
				return this._EvaluationManagementId;
			}
			set
			{
				if ((this._EvaluationManagementId != value))
				{
					if (this._EvaluationManagement.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEvaluationManagementIdChanging(value);
					this.SendPropertyChanging();
					this._EvaluationManagementId = value;
					this.SendPropertyChanged("EvaluationManagementId");
					this.OnEvaluationManagementIdChanged();
				}
			}
		}
		
		[Column(Storage="_QuestionId", DbType="Int NOT NULL")]
		public int QuestionId
		{
			get
			{
				return this._QuestionId;
			}
			set
			{
				if ((this._QuestionId != value))
				{
					if (this._Questions.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnQuestionIdChanging(value);
					this.SendPropertyChanging();
					this._QuestionId = value;
					this.SendPropertyChanged("QuestionId");
					this.OnQuestionIdChanged();
				}
			}
		}
		
		[Column(Storage="_Answer", DbType="NVarChar(500)")]
		public string Answer
		{
			get
			{
				return this._Answer;
			}
			set
			{
				if ((this._Answer != value))
				{
					this.OnAnswerChanging(value);
					this.SendPropertyChanging();
					this._Answer = value;
					this.SendPropertyChanged("Answer");
					this.OnAnswerChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedOn", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this.OnModifiedOnChanging(value);
					this.SendPropertyChanging();
					this._ModifiedOn = value;
					this.SendPropertyChanged("ModifiedOn");
					this.OnModifiedOnChanged();
				}
			}
		}
		
		[Column(Storage="_IsDelete", DbType="Bit NOT NULL")]
		public bool IsDelete
		{
			get
			{
				return this._IsDelete;
			}
			set
			{
				if ((this._IsDelete != value))
				{
					this.OnIsDeleteChanging(value);
					this.SendPropertyChanging();
					this._IsDelete = value;
					this.SendPropertyChanged("IsDelete");
					this.OnIsDeleteChanged();
				}
			}
		}
		
		[Association(Name="FK_SurveyResult_Questions", Storage="_Questions", ThisKey="QuestionId", OtherKey="QuestionId", IsForeignKey=true)]
		public Questions Questions
		{
			get
			{
				return this._Questions.Entity;
			}
			set
			{
				Questions previousValue = this._Questions.Entity;
				if (((previousValue != value) 
							|| (this._Questions.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Questions.Entity = null;
						previousValue.EvaluationResult.Remove(this);
					}
					this._Questions.Entity = value;
					if ((value != null))
					{
						value.EvaluationResult.Add(this);
						this._QuestionId = value.QuestionId;
					}
					else
					{
						this._QuestionId = default(int);
					}
					this.SendPropertyChanged("Questions");
				}
			}
		}
		
		[Association(Name="FK_SurveyResult_SurveyManagement", Storage="_EvaluationManagement", ThisKey="EvaluationManagementId", OtherKey="EvaluationManagementId", IsForeignKey=true)]
		public EvaluationManagement EvaluationManagement
		{
			get
			{
				return this._EvaluationManagement.Entity;
			}
			set
			{
				EvaluationManagement previousValue = this._EvaluationManagement.Entity;
				if (((previousValue != value) 
							|| (this._EvaluationManagement.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._EvaluationManagement.Entity = null;
						previousValue.EvaluationResult.Remove(this);
					}
					this._EvaluationManagement.Entity = value;
					if ((value != null))
					{
						value.EvaluationResult.Add(this);
						this._EvaluationManagementId = value.EvaluationManagementId;
					}
					else
					{
						this._EvaluationManagementId = default(int);
					}
					this.SendPropertyChanged("EvaluationManagement");
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
	
	[Table(Name="dbo.Exceptions")]
	public partial class Exceptions : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ExceptionId;
		
		private string _ExceptionMesage;
		
		private string _ExceptionSource;
		
		private string _FormName;
		
		private int _CreatedBy;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private string _ModifiedBy;
		
		private System.DateTime _ModifiedOn;
		
		private bool _IsDelete;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnExceptionIdChanging(int value);
    partial void OnExceptionIdChanged();
    partial void OnExceptionMesageChanging(string value);
    partial void OnExceptionMesageChanged();
    partial void OnExceptionSourceChanging(string value);
    partial void OnExceptionSourceChanged();
    partial void OnFormNameChanging(string value);
    partial void OnFormNameChanged();
    partial void OnCreatedByChanging(int value);
    partial void OnCreatedByChanged();
    partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnChanged();
    partial void OnModifiedByChanging(string value);
    partial void OnModifiedByChanged();
    partial void OnModifiedOnChanging(System.DateTime value);
    partial void OnModifiedOnChanged();
    partial void OnIsDeleteChanging(bool value);
    partial void OnIsDeleteChanged();
    #endregion
		
		public Exceptions()
		{
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[Column(Storage="_ExceptionId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ExceptionId
		{
			get
			{
				return this._ExceptionId;
			}
			set
			{
				if ((this._ExceptionId != value))
				{
					this.OnExceptionIdChanging(value);
					this.SendPropertyChanging();
					this._ExceptionId = value;
					this.SendPropertyChanged("ExceptionId");
					this.OnExceptionIdChanged();
				}
			}
		}
		
		[Column(Storage="_ExceptionMesage", DbType="NVarChar(500)")]
		public string ExceptionMesage
		{
			get
			{
				return this._ExceptionMesage;
			}
			set
			{
				if ((this._ExceptionMesage != value))
				{
					this.OnExceptionMesageChanging(value);
					this.SendPropertyChanging();
					this._ExceptionMesage = value;
					this.SendPropertyChanged("ExceptionMesage");
					this.OnExceptionMesageChanged();
				}
			}
		}
		
		[Column(Storage="_ExceptionSource", DbType="NVarChar(500)")]
		public string ExceptionSource
		{
			get
			{
				return this._ExceptionSource;
			}
			set
			{
				if ((this._ExceptionSource != value))
				{
					this.OnExceptionSourceChanging(value);
					this.SendPropertyChanging();
					this._ExceptionSource = value;
					this.SendPropertyChanged("ExceptionSource");
					this.OnExceptionSourceChanged();
				}
			}
		}
		
		[Column(Storage="_FormName", DbType="NVarChar(200)")]
		public string FormName
		{
			get
			{
				return this._FormName;
			}
			set
			{
				if ((this._FormName != value))
				{
					this.OnFormNameChanging(value);
					this.SendPropertyChanging();
					this._FormName = value;
					this.SendPropertyChanged("FormName");
					this.OnFormNameChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedBy", DbType="Int NOT NULL")]
		public int CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedOn", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this.OnModifiedOnChanging(value);
					this.SendPropertyChanging();
					this._ModifiedOn = value;
					this.SendPropertyChanged("ModifiedOn");
					this.OnModifiedOnChanged();
				}
			}
		}
		
		[Column(Storage="_IsDelete", DbType="Bit NOT NULL")]
		public bool IsDelete
		{
			get
			{
				return this._IsDelete;
			}
			set
			{
				if ((this._IsDelete != value))
				{
					this.OnIsDeleteChanging(value);
					this.SendPropertyChanging();
					this._IsDelete = value;
					this.SendPropertyChanged("IsDelete");
					this.OnIsDeleteChanged();
				}
			}
		}
		
		[Association(Name="FK_Exceptions_User", Storage="_User", ThisKey="CreatedBy", OtherKey="UserId", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Exceptions.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Exceptions.Add(this);
						this._CreatedBy = value.UserId;
					}
					else
					{
						this._CreatedBy = default(int);
					}
					this.SendPropertyChanged("User");
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
	
	[Table(Name="dbo.Forms")]
	public partial class Forms : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _FormId;
		
		private string _FormName;
		
		private string _FormPath;
		
		private string _CreatedBy;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private string _ModifiedBy;
		
		private System.DateTime _ModifiedOn;
		
		private bool _IsDelete;
		
		private EntitySet<RolesRightsManagement> _RolesRightsManagement;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFormIdChanging(int value);
    partial void OnFormIdChanged();
    partial void OnFormNameChanging(string value);
    partial void OnFormNameChanged();
    partial void OnFormPathChanging(string value);
    partial void OnFormPathChanged();
    partial void OnCreatedByChanging(string value);
    partial void OnCreatedByChanged();
    partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnChanged();
    partial void OnModifiedByChanging(string value);
    partial void OnModifiedByChanged();
    partial void OnModifiedOnChanging(System.DateTime value);
    partial void OnModifiedOnChanged();
    partial void OnIsDeleteChanging(bool value);
    partial void OnIsDeleteChanged();
    #endregion
		
		public Forms()
		{
			this._RolesRightsManagement = new EntitySet<RolesRightsManagement>(new Action<RolesRightsManagement>(this.attach_RolesRightsManagement), new Action<RolesRightsManagement>(this.detach_RolesRightsManagement));
			OnCreated();
		}
		
		[Column(Storage="_FormId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int FormId
		{
			get
			{
				return this._FormId;
			}
			set
			{
				if ((this._FormId != value))
				{
					this.OnFormIdChanging(value);
					this.SendPropertyChanging();
					this._FormId = value;
					this.SendPropertyChanged("FormId");
					this.OnFormIdChanged();
				}
			}
		}
		
		[Column(Storage="_FormName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string FormName
		{
			get
			{
				return this._FormName;
			}
			set
			{
				if ((this._FormName != value))
				{
					this.OnFormNameChanging(value);
					this.SendPropertyChanging();
					this._FormName = value;
					this.SendPropertyChanged("FormName");
					this.OnFormNameChanged();
				}
			}
		}
		
		[Column(Storage="_FormPath", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string FormPath
		{
			get
			{
				return this._FormPath;
			}
			set
			{
				if ((this._FormPath != value))
				{
					this.OnFormPathChanging(value);
					this.SendPropertyChanging();
					this._FormPath = value;
					this.SendPropertyChanged("FormPath");
					this.OnFormPathChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedOn", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this.OnModifiedOnChanging(value);
					this.SendPropertyChanging();
					this._ModifiedOn = value;
					this.SendPropertyChanged("ModifiedOn");
					this.OnModifiedOnChanged();
				}
			}
		}
		
		[Column(Storage="_IsDelete", DbType="Bit NOT NULL")]
		public bool IsDelete
		{
			get
			{
				return this._IsDelete;
			}
			set
			{
				if ((this._IsDelete != value))
				{
					this.OnIsDeleteChanging(value);
					this.SendPropertyChanging();
					this._IsDelete = value;
					this.SendPropertyChanged("IsDelete");
					this.OnIsDeleteChanged();
				}
			}
		}
		
		[Association(Name="FK_RolesRightsManagement_Forms", Storage="_RolesRightsManagement", ThisKey="FormId", OtherKey="FormId", DeleteRule="NO ACTION")]
		public EntitySet<RolesRightsManagement> RolesRightsManagement
		{
			get
			{
				return this._RolesRightsManagement;
			}
			set
			{
				this._RolesRightsManagement.Assign(value);
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
		
		private void attach_RolesRightsManagement(RolesRightsManagement entity)
		{
			this.SendPropertyChanging();
			entity.Forms = this;
		}
		
		private void detach_RolesRightsManagement(RolesRightsManagement entity)
		{
			this.SendPropertyChanging();
			entity.Forms = null;
		}
	}
	
	[Table(Name="dbo.Group")]
	public partial class Group : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _GroupId;
		
		private string _GroupName;
		
		private string _CreatedBy;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private string _ModifiedBy;
		
		private System.DateTime _ModifiedOn;
		
		private bool _IsDelete;
		
		private EntitySet<GroupMember> _GroupMember;
		
		private EntitySet<MailScheduling> _MailScheduling;
		
		private EntitySet<Evaluation> _Evaluation;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnGroupIdChanging(int value);
    partial void OnGroupIdChanged();
    partial void OnGroupNameChanging(string value);
    partial void OnGroupNameChanged();
    partial void OnCreatedByChanging(string value);
    partial void OnCreatedByChanged();
    partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnChanged();
    partial void OnModifiedByChanging(string value);
    partial void OnModifiedByChanged();
    partial void OnModifiedOnChanging(System.DateTime value);
    partial void OnModifiedOnChanged();
    partial void OnIsDeleteChanging(bool value);
    partial void OnIsDeleteChanged();
    #endregion
		
		public Group()
		{
			this._GroupMember = new EntitySet<GroupMember>(new Action<GroupMember>(this.attach_GroupMember), new Action<GroupMember>(this.detach_GroupMember));
			this._MailScheduling = new EntitySet<MailScheduling>(new Action<MailScheduling>(this.attach_MailScheduling), new Action<MailScheduling>(this.detach_MailScheduling));
			this._Evaluation = new EntitySet<Evaluation>(new Action<Evaluation>(this.attach_Evaluation), new Action<Evaluation>(this.detach_Evaluation));
			OnCreated();
		}
		
		[Column(Storage="_GroupId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int GroupId
		{
			get
			{
				return this._GroupId;
			}
			set
			{
				if ((this._GroupId != value))
				{
					this.OnGroupIdChanging(value);
					this.SendPropertyChanging();
					this._GroupId = value;
					this.SendPropertyChanged("GroupId");
					this.OnGroupIdChanged();
				}
			}
		}
		
		[Column(Storage="_GroupName", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string GroupName
		{
			get
			{
				return this._GroupName;
			}
			set
			{
				if ((this._GroupName != value))
				{
					this.OnGroupNameChanging(value);
					this.SendPropertyChanging();
					this._GroupName = value;
					this.SendPropertyChanged("GroupName");
					this.OnGroupNameChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedOn", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this.OnModifiedOnChanging(value);
					this.SendPropertyChanging();
					this._ModifiedOn = value;
					this.SendPropertyChanged("ModifiedOn");
					this.OnModifiedOnChanged();
				}
			}
		}
		
		[Column(Storage="_IsDelete", DbType="Bit NOT NULL")]
		public bool IsDelete
		{
			get
			{
				return this._IsDelete;
			}
			set
			{
				if ((this._IsDelete != value))
				{
					this.OnIsDeleteChanging(value);
					this.SendPropertyChanging();
					this._IsDelete = value;
					this.SendPropertyChanged("IsDelete");
					this.OnIsDeleteChanged();
				}
			}
		}
		
		[Association(Name="FK_GroupMember_Group", Storage="_GroupMember", ThisKey="GroupId", OtherKey="GroupId", DeleteRule="NO ACTION")]
		public EntitySet<GroupMember> GroupMember
		{
			get
			{
				return this._GroupMember;
			}
			set
			{
				this._GroupMember.Assign(value);
			}
		}
		
		[Association(Name="FK_MailScheduling_Group", Storage="_MailScheduling", ThisKey="GroupId", OtherKey="GroupId", DeleteRule="NO ACTION")]
		public EntitySet<MailScheduling> MailScheduling
		{
			get
			{
				return this._MailScheduling;
			}
			set
			{
				this._MailScheduling.Assign(value);
			}
		}
		
		[Association(Name="FK_Survey_Group", Storage="_Evaluation", ThisKey="GroupId", OtherKey="GroupId", DeleteRule="NO ACTION")]
		public EntitySet<Evaluation> Evaluation
		{
			get
			{
				return this._Evaluation;
			}
			set
			{
				this._Evaluation.Assign(value);
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
		
		private void attach_GroupMember(GroupMember entity)
		{
			this.SendPropertyChanging();
			entity.Group = this;
		}
		
		private void detach_GroupMember(GroupMember entity)
		{
			this.SendPropertyChanging();
			entity.Group = null;
		}
		
		private void attach_MailScheduling(MailScheduling entity)
		{
			this.SendPropertyChanging();
			entity.Group = this;
		}
		
		private void detach_MailScheduling(MailScheduling entity)
		{
			this.SendPropertyChanging();
			entity.Group = null;
		}
		
		private void attach_Evaluation(Evaluation entity)
		{
			this.SendPropertyChanging();
			entity.Group = this;
		}
		
		private void detach_Evaluation(Evaluation entity)
		{
			this.SendPropertyChanging();
			entity.Group = null;
		}
	}
	
	[Table(Name="dbo.GroupMember")]
	public partial class GroupMember : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _GroupMemberId;
		
		private int _GroupId;
		
		private int _UserId;
		
		private string _CreatedBy;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private string _ModifiedBy;
		
		private System.DateTime _ModifiedOn;
		
		private bool _IsDelete;
		
		private EntityRef<Group> _Group;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnGroupMemberIdChanging(int value);
    partial void OnGroupMemberIdChanged();
    partial void OnGroupIdChanging(int value);
    partial void OnGroupIdChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnCreatedByChanging(string value);
    partial void OnCreatedByChanged();
    partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnChanged();
    partial void OnModifiedByChanging(string value);
    partial void OnModifiedByChanged();
    partial void OnModifiedOnChanging(System.DateTime value);
    partial void OnModifiedOnChanged();
    partial void OnIsDeleteChanging(bool value);
    partial void OnIsDeleteChanged();
    #endregion
		
		public GroupMember()
		{
			this._Group = default(EntityRef<Group>);
			OnCreated();
		}
		
		[Column(Storage="_GroupMemberId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int GroupMemberId
		{
			get
			{
				return this._GroupMemberId;
			}
			set
			{
				if ((this._GroupMemberId != value))
				{
					this.OnGroupMemberIdChanging(value);
					this.SendPropertyChanging();
					this._GroupMemberId = value;
					this.SendPropertyChanged("GroupMemberId");
					this.OnGroupMemberIdChanged();
				}
			}
		}
		
		[Column(Storage="_GroupId", DbType="Int NOT NULL")]
		public int GroupId
		{
			get
			{
				return this._GroupId;
			}
			set
			{
				if ((this._GroupId != value))
				{
					if (this._Group.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGroupIdChanging(value);
					this.SendPropertyChanging();
					this._GroupId = value;
					this.SendPropertyChanged("GroupId");
					this.OnGroupIdChanged();
				}
			}
		}
		
		[Column(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedOn", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this.OnModifiedOnChanging(value);
					this.SendPropertyChanging();
					this._ModifiedOn = value;
					this.SendPropertyChanged("ModifiedOn");
					this.OnModifiedOnChanged();
				}
			}
		}
		
		[Column(Storage="_IsDelete", DbType="Bit NOT NULL")]
		public bool IsDelete
		{
			get
			{
				return this._IsDelete;
			}
			set
			{
				if ((this._IsDelete != value))
				{
					this.OnIsDeleteChanging(value);
					this.SendPropertyChanging();
					this._IsDelete = value;
					this.SendPropertyChanged("IsDelete");
					this.OnIsDeleteChanged();
				}
			}
		}
		
		[Association(Name="FK_GroupMember_Group", Storage="_Group", ThisKey="GroupId", OtherKey="GroupId", IsForeignKey=true)]
		public Group Group
		{
			get
			{
				return this._Group.Entity;
			}
			set
			{
				Group previousValue = this._Group.Entity;
				if (((previousValue != value) 
							|| (this._Group.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Group.Entity = null;
						previousValue.GroupMember.Remove(this);
					}
					this._Group.Entity = value;
					if ((value != null))
					{
						value.GroupMember.Add(this);
						this._GroupId = value.GroupId;
					}
					else
					{
						this._GroupId = default(int);
					}
					this.SendPropertyChanged("Group");
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
	
	[Table(Name="dbo.MailConfiguration")]
	public partial class MailConfiguration : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MailId;
		
		private string _MailAddress;
		
		private string _MailPassCode;
		
		private string _MailServer;
		
		private string _MailPort;
		
		private string _CreatedBy;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private string _ModifiedBy;
		
		private System.DateTime _ModifiedOn;
		
		private bool _IsDelete;
		
		private EntitySet<MailScheduling> _MailScheduling;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMailIdChanging(int value);
    partial void OnMailIdChanged();
    partial void OnMailAddressChanging(string value);
    partial void OnMailAddressChanged();
    partial void OnMailPassCodeChanging(string value);
    partial void OnMailPassCodeChanged();
    partial void OnMailServerChanging(string value);
    partial void OnMailServerChanged();
    partial void OnMailPortChanging(string value);
    partial void OnMailPortChanged();
    partial void OnCreatedByChanging(string value);
    partial void OnCreatedByChanged();
    partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnChanged();
    partial void OnModifiedByChanging(string value);
    partial void OnModifiedByChanged();
    partial void OnModifiedOnChanging(System.DateTime value);
    partial void OnModifiedOnChanged();
    partial void OnIsDeleteChanging(bool value);
    partial void OnIsDeleteChanged();
    #endregion
		
		public MailConfiguration()
		{
			this._MailScheduling = new EntitySet<MailScheduling>(new Action<MailScheduling>(this.attach_MailScheduling), new Action<MailScheduling>(this.detach_MailScheduling));
			OnCreated();
		}
		
		[Column(Storage="_MailId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MailId
		{
			get
			{
				return this._MailId;
			}
			set
			{
				if ((this._MailId != value))
				{
					this.OnMailIdChanging(value);
					this.SendPropertyChanging();
					this._MailId = value;
					this.SendPropertyChanged("MailId");
					this.OnMailIdChanged();
				}
			}
		}
		
		[Column(Storage="_MailAddress", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string MailAddress
		{
			get
			{
				return this._MailAddress;
			}
			set
			{
				if ((this._MailAddress != value))
				{
					this.OnMailAddressChanging(value);
					this.SendPropertyChanging();
					this._MailAddress = value;
					this.SendPropertyChanged("MailAddress");
					this.OnMailAddressChanged();
				}
			}
		}
		
		[Column(Storage="_MailPassCode", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
		public string MailPassCode
		{
			get
			{
				return this._MailPassCode;
			}
			set
			{
				if ((this._MailPassCode != value))
				{
					this.OnMailPassCodeChanging(value);
					this.SendPropertyChanging();
					this._MailPassCode = value;
					this.SendPropertyChanged("MailPassCode");
					this.OnMailPassCodeChanged();
				}
			}
		}
		
		[Column(Storage="_MailServer", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
		public string MailServer
		{
			get
			{
				return this._MailServer;
			}
			set
			{
				if ((this._MailServer != value))
				{
					this.OnMailServerChanging(value);
					this.SendPropertyChanging();
					this._MailServer = value;
					this.SendPropertyChanged("MailServer");
					this.OnMailServerChanged();
				}
			}
		}
		
		[Column(Storage="_MailPort", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
		public string MailPort
		{
			get
			{
				return this._MailPort;
			}
			set
			{
				if ((this._MailPort != value))
				{
					this.OnMailPortChanging(value);
					this.SendPropertyChanging();
					this._MailPort = value;
					this.SendPropertyChanged("MailPort");
					this.OnMailPortChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedOn", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this.OnModifiedOnChanging(value);
					this.SendPropertyChanging();
					this._ModifiedOn = value;
					this.SendPropertyChanged("ModifiedOn");
					this.OnModifiedOnChanged();
				}
			}
		}
		
		[Column(Storage="_IsDelete", DbType="Bit NOT NULL")]
		public bool IsDelete
		{
			get
			{
				return this._IsDelete;
			}
			set
			{
				if ((this._IsDelete != value))
				{
					this.OnIsDeleteChanging(value);
					this.SendPropertyChanging();
					this._IsDelete = value;
					this.SendPropertyChanged("IsDelete");
					this.OnIsDeleteChanged();
				}
			}
		}
		
		[Association(Name="FK_MailScheduling_MailConfiguration", Storage="_MailScheduling", ThisKey="MailId", OtherKey="MailConfigurationID", DeleteRule="NO ACTION")]
		public EntitySet<MailScheduling> MailScheduling
		{
			get
			{
				return this._MailScheduling;
			}
			set
			{
				this._MailScheduling.Assign(value);
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
		
		private void attach_MailScheduling(MailScheduling entity)
		{
			this.SendPropertyChanging();
			entity.MailConfiguration = this;
		}
		
		private void detach_MailScheduling(MailScheduling entity)
		{
			this.SendPropertyChanging();
			entity.MailConfiguration = null;
		}
	}
	
	[Table(Name="dbo.MailScheduling")]
	public partial class MailScheduling : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MailSchedulingId;
		
		private int _GroupId;
		
		private string _GroupName;
		
		private int _MailConfigurationID;
		
		private string _MessageText;
		
		private string _CreatedBy;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private string _ModifiedBy;
		
		private System.DateTime _ModifiedOn;
		
		private string _IsDelete;
		
		private EntityRef<Group> _Group;
		
		private EntityRef<MailConfiguration> _MailConfiguration;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMailSchedulingIdChanging(int value);
    partial void OnMailSchedulingIdChanged();
    partial void OnGroupIdChanging(int value);
    partial void OnGroupIdChanged();
    partial void OnGroupNameChanging(string value);
    partial void OnGroupNameChanged();
    partial void OnMailConfigurationIDChanging(int value);
    partial void OnMailConfigurationIDChanged();
    partial void OnMessageTextChanging(string value);
    partial void OnMessageTextChanged();
    partial void OnCreatedByChanging(string value);
    partial void OnCreatedByChanged();
    partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnChanged();
    partial void OnModifiedByChanging(string value);
    partial void OnModifiedByChanged();
    partial void OnModifiedOnChanging(System.DateTime value);
    partial void OnModifiedOnChanged();
    partial void OnIsDeleteChanging(string value);
    partial void OnIsDeleteChanged();
    #endregion
		
		public MailScheduling()
		{
			this._Group = default(EntityRef<Group>);
			this._MailConfiguration = default(EntityRef<MailConfiguration>);
			OnCreated();
		}
		
		[Column(Storage="_MailSchedulingId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MailSchedulingId
		{
			get
			{
				return this._MailSchedulingId;
			}
			set
			{
				if ((this._MailSchedulingId != value))
				{
					this.OnMailSchedulingIdChanging(value);
					this.SendPropertyChanging();
					this._MailSchedulingId = value;
					this.SendPropertyChanged("MailSchedulingId");
					this.OnMailSchedulingIdChanged();
				}
			}
		}
		
		[Column(Storage="_GroupId", DbType="Int NOT NULL")]
		public int GroupId
		{
			get
			{
				return this._GroupId;
			}
			set
			{
				if ((this._GroupId != value))
				{
					if (this._Group.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGroupIdChanging(value);
					this.SendPropertyChanging();
					this._GroupId = value;
					this.SendPropertyChanged("GroupId");
					this.OnGroupIdChanged();
				}
			}
		}
		
		[Column(Storage="_GroupName", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string GroupName
		{
			get
			{
				return this._GroupName;
			}
			set
			{
				if ((this._GroupName != value))
				{
					this.OnGroupNameChanging(value);
					this.SendPropertyChanging();
					this._GroupName = value;
					this.SendPropertyChanged("GroupName");
					this.OnGroupNameChanged();
				}
			}
		}
		
		[Column(Storage="_MailConfigurationID", DbType="Int NOT NULL")]
		public int MailConfigurationID
		{
			get
			{
				return this._MailConfigurationID;
			}
			set
			{
				if ((this._MailConfigurationID != value))
				{
					if (this._MailConfiguration.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMailConfigurationIDChanging(value);
					this.SendPropertyChanging();
					this._MailConfigurationID = value;
					this.SendPropertyChanged("MailConfigurationID");
					this.OnMailConfigurationIDChanged();
				}
			}
		}
		
		[Column(Storage="_MessageText", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
		public string MessageText
		{
			get
			{
				return this._MessageText;
			}
			set
			{
				if ((this._MessageText != value))
				{
					this.OnMessageTextChanging(value);
					this.SendPropertyChanging();
					this._MessageText = value;
					this.SendPropertyChanged("MessageText");
					this.OnMessageTextChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedOn", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this.OnModifiedOnChanging(value);
					this.SendPropertyChanging();
					this._ModifiedOn = value;
					this.SendPropertyChanged("ModifiedOn");
					this.OnModifiedOnChanged();
				}
			}
		}
		
		[Column(Storage="_IsDelete", DbType="NVarChar(1) NOT NULL", CanBeNull=false)]
		public string IsDelete
		{
			get
			{
				return this._IsDelete;
			}
			set
			{
				if ((this._IsDelete != value))
				{
					this.OnIsDeleteChanging(value);
					this.SendPropertyChanging();
					this._IsDelete = value;
					this.SendPropertyChanged("IsDelete");
					this.OnIsDeleteChanged();
				}
			}
		}
		
		[Association(Name="FK_MailScheduling_Group", Storage="_Group", ThisKey="GroupId", OtherKey="GroupId", IsForeignKey=true)]
		public Group Group
		{
			get
			{
				return this._Group.Entity;
			}
			set
			{
				Group previousValue = this._Group.Entity;
				if (((previousValue != value) 
							|| (this._Group.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Group.Entity = null;
						previousValue.MailScheduling.Remove(this);
					}
					this._Group.Entity = value;
					if ((value != null))
					{
						value.MailScheduling.Add(this);
						this._GroupId = value.GroupId;
					}
					else
					{
						this._GroupId = default(int);
					}
					this.SendPropertyChanged("Group");
				}
			}
		}
		
		[Association(Name="FK_MailScheduling_MailConfiguration", Storage="_MailConfiguration", ThisKey="MailConfigurationID", OtherKey="MailId", IsForeignKey=true)]
		public MailConfiguration MailConfiguration
		{
			get
			{
				return this._MailConfiguration.Entity;
			}
			set
			{
				MailConfiguration previousValue = this._MailConfiguration.Entity;
				if (((previousValue != value) 
							|| (this._MailConfiguration.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._MailConfiguration.Entity = null;
						previousValue.MailScheduling.Remove(this);
					}
					this._MailConfiguration.Entity = value;
					if ((value != null))
					{
						value.MailScheduling.Add(this);
						this._MailConfigurationID = value.MailId;
					}
					else
					{
						this._MailConfigurationID = default(int);
					}
					this.SendPropertyChanged("MailConfiguration");
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
	
	[Table(Name="dbo.Questions")]
	public partial class Questions : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _QuestionId;
		
		private string _Question;
		
		private int _AnswerTypeId;
		
		private string _CreatedBy;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private string _ModifiedBy;
		
		private System.DateTime _ModifiedOn;
		
		private bool _IsDelete;
		
		private int _Weight;
		
		private bool _IsKPI;
		
		private EntitySet<EvaluationManagement> _EvaluationManagement;
		
		private EntityRef<AnswerType> _AnswerType;
		
		private EntitySet<EvaluationResult> _EvaluationResult;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnQuestionIdChanging(int value);
    partial void OnQuestionIdChanged();
    partial void OnQuestionChanging(string value);
    partial void OnQuestionChanged();
    partial void OnAnswerTypeIdChanging(int value);
    partial void OnAnswerTypeIdChanged();
    partial void OnCreatedByChanging(string value);
    partial void OnCreatedByChanged();
    partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnChanged();
    partial void OnModifiedByChanging(string value);
    partial void OnModifiedByChanged();
    partial void OnModifiedOnChanging(System.DateTime value);
    partial void OnModifiedOnChanged();
    partial void OnIsDeleteChanging(bool value);
    partial void OnIsDeleteChanged();
    partial void OnWeightChanging(int value);
    partial void OnWeightChanged();
    partial void OnIsKPIChanging(bool value);
    partial void OnIsKPIChanged();
    #endregion
		
		public Questions()
		{
			this._EvaluationManagement = new EntitySet<EvaluationManagement>(new Action<EvaluationManagement>(this.attach_EvaluationManagement), new Action<EvaluationManagement>(this.detach_EvaluationManagement));
			this._AnswerType = default(EntityRef<AnswerType>);
			this._EvaluationResult = new EntitySet<EvaluationResult>(new Action<EvaluationResult>(this.attach_EvaluationResult), new Action<EvaluationResult>(this.detach_EvaluationResult));
			OnCreated();
		}
		
		[Column(Storage="_QuestionId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int QuestionId
		{
			get
			{
				return this._QuestionId;
			}
			set
			{
				if ((this._QuestionId != value))
				{
					this.OnQuestionIdChanging(value);
					this.SendPropertyChanging();
					this._QuestionId = value;
					this.SendPropertyChanged("QuestionId");
					this.OnQuestionIdChanged();
				}
			}
		}
		
		[Column(Storage="_Question", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
		public string Question
		{
			get
			{
				return this._Question;
			}
			set
			{
				if ((this._Question != value))
				{
					this.OnQuestionChanging(value);
					this.SendPropertyChanging();
					this._Question = value;
					this.SendPropertyChanged("Question");
					this.OnQuestionChanged();
				}
			}
		}
		
		[Column(Storage="_AnswerTypeId", DbType="Int NOT NULL")]
		public int AnswerTypeId
		{
			get
			{
				return this._AnswerTypeId;
			}
			set
			{
				if ((this._AnswerTypeId != value))
				{
					if (this._AnswerType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAnswerTypeIdChanging(value);
					this.SendPropertyChanging();
					this._AnswerTypeId = value;
					this.SendPropertyChanged("AnswerTypeId");
					this.OnAnswerTypeIdChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedOn", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this.OnModifiedOnChanging(value);
					this.SendPropertyChanging();
					this._ModifiedOn = value;
					this.SendPropertyChanged("ModifiedOn");
					this.OnModifiedOnChanged();
				}
			}
		}
		
		[Column(Storage="_IsDelete", DbType="Bit NOT NULL")]
		public bool IsDelete
		{
			get
			{
				return this._IsDelete;
			}
			set
			{
				if ((this._IsDelete != value))
				{
					this.OnIsDeleteChanging(value);
					this.SendPropertyChanging();
					this._IsDelete = value;
					this.SendPropertyChanged("IsDelete");
					this.OnIsDeleteChanged();
				}
			}
		}
		
		[Column(Storage="_Weight", DbType="Int NOT NULL")]
		public int Weight
		{
			get
			{
				return this._Weight;
			}
			set
			{
				if ((this._Weight != value))
				{
					this.OnWeightChanging(value);
					this.SendPropertyChanging();
					this._Weight = value;
					this.SendPropertyChanged("Weight");
					this.OnWeightChanged();
				}
			}
		}
		
		[Column(Storage="_IsKPI", DbType="Bit NOT NULL")]
		public bool IsKPI
		{
			get
			{
				return this._IsKPI;
			}
			set
			{
				if ((this._IsKPI != value))
				{
					this.OnIsKPIChanging(value);
					this.SendPropertyChanging();
					this._IsKPI = value;
					this.SendPropertyChanged("IsKPI");
					this.OnIsKPIChanged();
				}
			}
		}
		
		[Association(Name="FK_EVALUATIONMGMT_QUESTION", Storage="_EvaluationManagement", ThisKey="QuestionId", OtherKey="QuestionId", DeleteRule="NO ACTION")]
		public EntitySet<EvaluationManagement> EvaluationManagement
		{
			get
			{
				return this._EvaluationManagement;
			}
			set
			{
				this._EvaluationManagement.Assign(value);
			}
		}
		
		[Association(Name="FK_Questions_AnswerType", Storage="_AnswerType", ThisKey="AnswerTypeId", OtherKey="AnswerTypeId", IsForeignKey=true)]
		public AnswerType AnswerType
		{
			get
			{
				return this._AnswerType.Entity;
			}
			set
			{
				AnswerType previousValue = this._AnswerType.Entity;
				if (((previousValue != value) 
							|| (this._AnswerType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._AnswerType.Entity = null;
						previousValue.Questions.Remove(this);
					}
					this._AnswerType.Entity = value;
					if ((value != null))
					{
						value.Questions.Add(this);
						this._AnswerTypeId = value.AnswerTypeId;
					}
					else
					{
						this._AnswerTypeId = default(int);
					}
					this.SendPropertyChanged("AnswerType");
				}
			}
		}
		
		[Association(Name="FK_SurveyResult_Questions", Storage="_EvaluationResult", ThisKey="QuestionId", OtherKey="QuestionId", DeleteRule="NO ACTION")]
		public EntitySet<EvaluationResult> EvaluationResult
		{
			get
			{
				return this._EvaluationResult;
			}
			set
			{
				this._EvaluationResult.Assign(value);
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
		
		private void attach_EvaluationManagement(EvaluationManagement entity)
		{
			this.SendPropertyChanging();
			entity.Questions = this;
		}
		
		private void detach_EvaluationManagement(EvaluationManagement entity)
		{
			this.SendPropertyChanging();
			entity.Questions = null;
		}
		
		private void attach_EvaluationResult(EvaluationResult entity)
		{
			this.SendPropertyChanging();
			entity.Questions = this;
		}
		
		private void detach_EvaluationResult(EvaluationResult entity)
		{
			this.SendPropertyChanging();
			entity.Questions = null;
		}
	}
	
	[Table(Name="dbo.Role")]
	public partial class Role : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RoleId;
		
		private string _Role1;
		
		private string _CreatedBy;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private string _ModifiedBy;
		
		private System.DateTime _ModifiedOn;
		
		private bool _IsDelete;
		
		private EntitySet<RolesRightsManagement> _RolesRightsManagement;
		
		private EntitySet<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRoleIdChanging(int value);
    partial void OnRoleIdChanged();
    partial void OnRole1Changing(string value);
    partial void OnRole1Changed();
    partial void OnCreatedByChanging(string value);
    partial void OnCreatedByChanged();
    partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnChanged();
    partial void OnModifiedByChanging(string value);
    partial void OnModifiedByChanged();
    partial void OnModifiedOnChanging(System.DateTime value);
    partial void OnModifiedOnChanged();
    partial void OnIsDeleteChanging(bool value);
    partial void OnIsDeleteChanged();
    #endregion
		
		public Role()
		{
			this._RolesRightsManagement = new EntitySet<RolesRightsManagement>(new Action<RolesRightsManagement>(this.attach_RolesRightsManagement), new Action<RolesRightsManagement>(this.detach_RolesRightsManagement));
			this._User = new EntitySet<User>(new Action<User>(this.attach_User), new Action<User>(this.detach_User));
			OnCreated();
		}
		
		[Column(Storage="_RoleId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int RoleId
		{
			get
			{
				return this._RoleId;
			}
			set
			{
				if ((this._RoleId != value))
				{
					this.OnRoleIdChanging(value);
					this.SendPropertyChanging();
					this._RoleId = value;
					this.SendPropertyChanged("RoleId");
					this.OnRoleIdChanged();
				}
			}
		}
		
		[Column(Name="Role", Storage="_Role1", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string Role1
		{
			get
			{
				return this._Role1;
			}
			set
			{
				if ((this._Role1 != value))
				{
					this.OnRole1Changing(value);
					this.SendPropertyChanging();
					this._Role1 = value;
					this.SendPropertyChanged("Role1");
					this.OnRole1Changed();
				}
			}
		}
		
		[Column(Storage="_CreatedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedOn", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this.OnModifiedOnChanging(value);
					this.SendPropertyChanging();
					this._ModifiedOn = value;
					this.SendPropertyChanged("ModifiedOn");
					this.OnModifiedOnChanged();
				}
			}
		}
		
		[Column(Storage="_IsDelete", DbType="Bit NOT NULL")]
		public bool IsDelete
		{
			get
			{
				return this._IsDelete;
			}
			set
			{
				if ((this._IsDelete != value))
				{
					this.OnIsDeleteChanging(value);
					this.SendPropertyChanging();
					this._IsDelete = value;
					this.SendPropertyChanged("IsDelete");
					this.OnIsDeleteChanged();
				}
			}
		}
		
		[Association(Name="FK_RolesRightsManagement_Role", Storage="_RolesRightsManagement", ThisKey="RoleId", OtherKey="RoleId", DeleteRule="NO ACTION")]
		public EntitySet<RolesRightsManagement> RolesRightsManagement
		{
			get
			{
				return this._RolesRightsManagement;
			}
			set
			{
				this._RolesRightsManagement.Assign(value);
			}
		}
		
		[Association(Name="FK_User_Role", Storage="_User", ThisKey="RoleId", OtherKey="RoleId", DeleteRule="NO ACTION")]
		public EntitySet<User> User
		{
			get
			{
				return this._User;
			}
			set
			{
				this._User.Assign(value);
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
		
		private void attach_RolesRightsManagement(RolesRightsManagement entity)
		{
			this.SendPropertyChanging();
			entity.Role = this;
		}
		
		private void detach_RolesRightsManagement(RolesRightsManagement entity)
		{
			this.SendPropertyChanging();
			entity.Role = null;
		}
		
		private void attach_User(User entity)
		{
			this.SendPropertyChanging();
			entity.Role = this;
		}
		
		private void detach_User(User entity)
		{
			this.SendPropertyChanging();
			entity.Role = null;
		}
	}
	
	[Table(Name="dbo.RolesRightsManagement")]
	public partial class RolesRightsManagement : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RoleRightsId;
		
		private int _RoleId;
		
		private int _FormId;
		
		private bool _IsAdd;
		
		private bool _IsUpdate;
		
		private bool _IsView;
		
		private string _CreatedBy;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private string _ModifiedBy;
		
		private System.DateTime _ModifiedOn;
		
		private bool _IsDelete;
		
		private EntityRef<Forms> _Forms;
		
		private EntityRef<Role> _Role;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRoleRightsIdChanging(int value);
    partial void OnRoleRightsIdChanged();
    partial void OnRoleIdChanging(int value);
    partial void OnRoleIdChanged();
    partial void OnFormIdChanging(int value);
    partial void OnFormIdChanged();
    partial void OnIsAddChanging(bool value);
    partial void OnIsAddChanged();
    partial void OnIsUpdateChanging(bool value);
    partial void OnIsUpdateChanged();
    partial void OnIsViewChanging(bool value);
    partial void OnIsViewChanged();
    partial void OnCreatedByChanging(string value);
    partial void OnCreatedByChanged();
    partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnChanged();
    partial void OnModifiedByChanging(string value);
    partial void OnModifiedByChanged();
    partial void OnModifiedOnChanging(System.DateTime value);
    partial void OnModifiedOnChanged();
    partial void OnIsDeleteChanging(bool value);
    partial void OnIsDeleteChanged();
    #endregion
		
		public RolesRightsManagement()
		{
			this._Forms = default(EntityRef<Forms>);
			this._Role = default(EntityRef<Role>);
			OnCreated();
		}
		
		[Column(Storage="_RoleRightsId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int RoleRightsId
		{
			get
			{
				return this._RoleRightsId;
			}
			set
			{
				if ((this._RoleRightsId != value))
				{
					this.OnRoleRightsIdChanging(value);
					this.SendPropertyChanging();
					this._RoleRightsId = value;
					this.SendPropertyChanged("RoleRightsId");
					this.OnRoleRightsIdChanged();
				}
			}
		}
		
		[Column(Storage="_RoleId", DbType="Int NOT NULL")]
		public int RoleId
		{
			get
			{
				return this._RoleId;
			}
			set
			{
				if ((this._RoleId != value))
				{
					if (this._Role.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRoleIdChanging(value);
					this.SendPropertyChanging();
					this._RoleId = value;
					this.SendPropertyChanged("RoleId");
					this.OnRoleIdChanged();
				}
			}
		}
		
		[Column(Storage="_FormId", DbType="Int NOT NULL")]
		public int FormId
		{
			get
			{
				return this._FormId;
			}
			set
			{
				if ((this._FormId != value))
				{
					if (this._Forms.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnFormIdChanging(value);
					this.SendPropertyChanging();
					this._FormId = value;
					this.SendPropertyChanged("FormId");
					this.OnFormIdChanged();
				}
			}
		}
		
		[Column(Storage="_IsAdd", DbType="Bit NOT NULL")]
		public bool IsAdd
		{
			get
			{
				return this._IsAdd;
			}
			set
			{
				if ((this._IsAdd != value))
				{
					this.OnIsAddChanging(value);
					this.SendPropertyChanging();
					this._IsAdd = value;
					this.SendPropertyChanged("IsAdd");
					this.OnIsAddChanged();
				}
			}
		}
		
		[Column(Storage="_IsUpdate", DbType="Bit NOT NULL")]
		public bool IsUpdate
		{
			get
			{
				return this._IsUpdate;
			}
			set
			{
				if ((this._IsUpdate != value))
				{
					this.OnIsUpdateChanging(value);
					this.SendPropertyChanging();
					this._IsUpdate = value;
					this.SendPropertyChanged("IsUpdate");
					this.OnIsUpdateChanged();
				}
			}
		}
		
		[Column(Storage="_IsView", DbType="Bit NOT NULL")]
		public bool IsView
		{
			get
			{
				return this._IsView;
			}
			set
			{
				if ((this._IsView != value))
				{
					this.OnIsViewChanging(value);
					this.SendPropertyChanging();
					this._IsView = value;
					this.SendPropertyChanged("IsView");
					this.OnIsViewChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedOn", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this.OnModifiedOnChanging(value);
					this.SendPropertyChanging();
					this._ModifiedOn = value;
					this.SendPropertyChanged("ModifiedOn");
					this.OnModifiedOnChanged();
				}
			}
		}
		
		[Column(Storage="_IsDelete", DbType="Bit NOT NULL")]
		public bool IsDelete
		{
			get
			{
				return this._IsDelete;
			}
			set
			{
				if ((this._IsDelete != value))
				{
					this.OnIsDeleteChanging(value);
					this.SendPropertyChanging();
					this._IsDelete = value;
					this.SendPropertyChanged("IsDelete");
					this.OnIsDeleteChanged();
				}
			}
		}
		
		[Association(Name="FK_RolesRightsManagement_Forms", Storage="_Forms", ThisKey="FormId", OtherKey="FormId", IsForeignKey=true)]
		public Forms Forms
		{
			get
			{
				return this._Forms.Entity;
			}
			set
			{
				Forms previousValue = this._Forms.Entity;
				if (((previousValue != value) 
							|| (this._Forms.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Forms.Entity = null;
						previousValue.RolesRightsManagement.Remove(this);
					}
					this._Forms.Entity = value;
					if ((value != null))
					{
						value.RolesRightsManagement.Add(this);
						this._FormId = value.FormId;
					}
					else
					{
						this._FormId = default(int);
					}
					this.SendPropertyChanged("Forms");
				}
			}
		}
		
		[Association(Name="FK_RolesRightsManagement_Role", Storage="_Role", ThisKey="RoleId", OtherKey="RoleId", IsForeignKey=true)]
		public Role Role
		{
			get
			{
				return this._Role.Entity;
			}
			set
			{
				Role previousValue = this._Role.Entity;
				if (((previousValue != value) 
							|| (this._Role.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Role.Entity = null;
						previousValue.RolesRightsManagement.Remove(this);
					}
					this._Role.Entity = value;
					if ((value != null))
					{
						value.RolesRightsManagement.Add(this);
						this._RoleId = value.RoleId;
					}
					else
					{
						this._RoleId = default(int);
					}
					this.SendPropertyChanged("Role");
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
	
	[Table(Name="dbo.User")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserId;
		
		private string _UserName;
		
		private string _FirstName;
		
		private string _LastName;
		
		private int _RoleId;
		
		private string _Password;
		
		private string _CreatedBy;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private string _ModifiedBy;
		
		private System.DateTime _ModifiedOn;
		
		private bool _IsDelete;
		
		private EntitySet<ActivityLog> _ActivityLog;
		
		private EntitySet<Exceptions> _Exceptions;
		
		private EntitySet<Evaluation> _Evaluation;
		
		private EntityRef<Role> _Role;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnRoleIdChanging(int value);
    partial void OnRoleIdChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnCreatedByChanging(string value);
    partial void OnCreatedByChanged();
    partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnChanged();
    partial void OnModifiedByChanging(string value);
    partial void OnModifiedByChanged();
    partial void OnModifiedOnChanging(System.DateTime value);
    partial void OnModifiedOnChanged();
    partial void OnIsDeleteChanging(bool value);
    partial void OnIsDeleteChanged();
    #endregion
		
		public User()
		{
			this._ActivityLog = new EntitySet<ActivityLog>(new Action<ActivityLog>(this.attach_ActivityLog), new Action<ActivityLog>(this.detach_ActivityLog));
			this._Exceptions = new EntitySet<Exceptions>(new Action<Exceptions>(this.attach_Exceptions), new Action<Exceptions>(this.detach_Exceptions));
			this._Evaluation = new EntitySet<Evaluation>(new Action<Evaluation>(this.attach_Evaluation), new Action<Evaluation>(this.detach_Evaluation));
			this._Role = default(EntityRef<Role>);
			OnCreated();
		}
		
		[Column(Storage="_UserId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[Column(Storage="_UserName", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
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
		
		[Column(Storage="_FirstName", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[Column(Storage="_LastName", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[Column(Storage="_RoleId", DbType="Int NOT NULL")]
		public int RoleId
		{
			get
			{
				return this._RoleId;
			}
			set
			{
				if ((this._RoleId != value))
				{
					if (this._Role.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRoleIdChanging(value);
					this.SendPropertyChanging();
					this._RoleId = value;
					this.SendPropertyChanged("RoleId");
					this.OnRoleIdChanged();
				}
			}
		}
		
		[Column(Storage="_Password", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
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
		
		[Column(Storage="_CreatedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedBy", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedOn", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this.OnModifiedOnChanging(value);
					this.SendPropertyChanging();
					this._ModifiedOn = value;
					this.SendPropertyChanged("ModifiedOn");
					this.OnModifiedOnChanged();
				}
			}
		}
		
		[Column(Storage="_IsDelete", DbType="Bit NOT NULL")]
		public bool IsDelete
		{
			get
			{
				return this._IsDelete;
			}
			set
			{
				if ((this._IsDelete != value))
				{
					this.OnIsDeleteChanging(value);
					this.SendPropertyChanging();
					this._IsDelete = value;
					this.SendPropertyChanged("IsDelete");
					this.OnIsDeleteChanged();
				}
			}
		}
		
		[Association(Name="FK_ActivityLog_User", Storage="_ActivityLog", ThisKey="UserId", OtherKey="CreatedBy", DeleteRule="NO ACTION")]
		public EntitySet<ActivityLog> ActivityLog
		{
			get
			{
				return this._ActivityLog;
			}
			set
			{
				this._ActivityLog.Assign(value);
			}
		}
		
		[Association(Name="FK_Exceptions_User", Storage="_Exceptions", ThisKey="UserId", OtherKey="CreatedBy", DeleteRule="NO ACTION")]
		public EntitySet<Exceptions> Exceptions
		{
			get
			{
				return this._Exceptions;
			}
			set
			{
				this._Exceptions.Assign(value);
			}
		}
		
		[Association(Name="FK_Survey_User", Storage="_Evaluation", ThisKey="UserId", OtherKey="RevieweeId", DeleteRule="NO ACTION")]
		public EntitySet<Evaluation> Evaluation
		{
			get
			{
				return this._Evaluation;
			}
			set
			{
				this._Evaluation.Assign(value);
			}
		}
		
		[Association(Name="FK_User_Role", Storage="_Role", ThisKey="RoleId", OtherKey="RoleId", IsForeignKey=true)]
		public Role Role
		{
			get
			{
				return this._Role.Entity;
			}
			set
			{
				Role previousValue = this._Role.Entity;
				if (((previousValue != value) 
							|| (this._Role.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Role.Entity = null;
						previousValue.User.Remove(this);
					}
					this._Role.Entity = value;
					if ((value != null))
					{
						value.User.Add(this);
						this._RoleId = value.RoleId;
					}
					else
					{
						this._RoleId = default(int);
					}
					this.SendPropertyChanged("Role");
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
		
		private void attach_ActivityLog(ActivityLog entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_ActivityLog(ActivityLog entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_Exceptions(Exceptions entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Exceptions(Exceptions entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_Evaluation(Evaluation entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Evaluation(Evaluation entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
}