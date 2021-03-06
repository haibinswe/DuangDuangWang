﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace duangduangwang.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertBook(Book instance);
    partial void UpdateBook(Book instance);
    partial void DeleteBook(Book instance);
    partial void InsertBookOrder(BookOrder instance);
    partial void UpdateBookOrder(BookOrder instance);
    partial void DeleteBookOrder(BookOrder instance);
    partial void InsertComment(Comment instance);
    partial void UpdateComment(Comment instance);
    partial void DeleteComment(Comment instance);
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertOrderItem(OrderItem instance);
    partial void UpdateOrderItem(OrderItem instance);
    partial void DeleteOrderItem(OrderItem instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::duangduangwang.Properties.Settings.Default.DatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Book> Book
		{
			get
			{
				return this.GetTable<Book>();
			}
		}
		
		public System.Data.Linq.Table<BookOrder> BookOrder
		{
			get
			{
				return this.GetTable<BookOrder>();
			}
		}
		
		public System.Data.Linq.Table<Comment> Comment
		{
			get
			{
				return this.GetTable<Comment>();
			}
		}
		
		public System.Data.Linq.Table<Customer> Customer
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<OrderItem> OrderItem
		{
			get
			{
				return this.GetTable<OrderItem>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Book")]
	public partial class Book : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BookId;
		
		private string _BookName;
		
		private string _BookAbstract;
		
		private string _BookWriter;
		
		private string _BookPublisher;
		
		private System.Nullable<System.DateTime> _PublishTime;
		
		private string _Picture1;
		
		private string _Picture2;
		
		private string _Picture3;
		
		private System.Nullable<int> _Coupon;
		
		private string _BookType;
		
		private System.Nullable<double> _BookPrice;
		
		private string _CouponDetail;
		
		private EntitySet<Comment> _Comment;
		
		private EntitySet<OrderItem> _OrderItem;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBookIdChanging(int value);
    partial void OnBookIdChanged();
    partial void OnBookNameChanging(string value);
    partial void OnBookNameChanged();
    partial void OnBookAbstractChanging(string value);
    partial void OnBookAbstractChanged();
    partial void OnBookWriterChanging(string value);
    partial void OnBookWriterChanged();
    partial void OnBookPublisherChanging(string value);
    partial void OnBookPublisherChanged();
    partial void OnPublishTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnPublishTimeChanged();
    partial void OnPicture1Changing(string value);
    partial void OnPicture1Changed();
    partial void OnPicture2Changing(string value);
    partial void OnPicture2Changed();
    partial void OnPicture3Changing(string value);
    partial void OnPicture3Changed();
    partial void OnCouponChanging(System.Nullable<int> value);
    partial void OnCouponChanged();
    partial void OnBookTypeChanging(string value);
    partial void OnBookTypeChanged();
    partial void OnBookPriceChanging(System.Nullable<double> value);
    partial void OnBookPriceChanged();
    partial void OnCouponDetailChanging(string value);
    partial void OnCouponDetailChanged();
    #endregion
		
		public Book()
		{
			this._Comment = new EntitySet<Comment>(new Action<Comment>(this.attach_Comment), new Action<Comment>(this.detach_Comment));
			this._OrderItem = new EntitySet<OrderItem>(new Action<OrderItem>(this.attach_OrderItem), new Action<OrderItem>(this.detach_OrderItem));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int BookId
		{
			get
			{
				return this._BookId;
			}
			set
			{
				if ((this._BookId != value))
				{
					this.OnBookIdChanging(value);
					this.SendPropertyChanging();
					this._BookId = value;
					this.SendPropertyChanged("BookId");
					this.OnBookIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookName", DbType="NVarChar(50)")]
		public string BookName
		{
			get
			{
				return this._BookName;
			}
			set
			{
				if ((this._BookName != value))
				{
					this.OnBookNameChanging(value);
					this.SendPropertyChanging();
					this._BookName = value;
					this.SendPropertyChanged("BookName");
					this.OnBookNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookAbstract", DbType="NVarChar(200)")]
		public string BookAbstract
		{
			get
			{
				return this._BookAbstract;
			}
			set
			{
				if ((this._BookAbstract != value))
				{
					this.OnBookAbstractChanging(value);
					this.SendPropertyChanging();
					this._BookAbstract = value;
					this.SendPropertyChanged("BookAbstract");
					this.OnBookAbstractChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookWriter", DbType="NVarChar(20)")]
		public string BookWriter
		{
			get
			{
				return this._BookWriter;
			}
			set
			{
				if ((this._BookWriter != value))
				{
					this.OnBookWriterChanging(value);
					this.SendPropertyChanging();
					this._BookWriter = value;
					this.SendPropertyChanged("BookWriter");
					this.OnBookWriterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookPublisher", DbType="NVarChar(50)")]
		public string BookPublisher
		{
			get
			{
				return this._BookPublisher;
			}
			set
			{
				if ((this._BookPublisher != value))
				{
					this.OnBookPublisherChanging(value);
					this.SendPropertyChanging();
					this._BookPublisher = value;
					this.SendPropertyChanged("BookPublisher");
					this.OnBookPublisherChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PublishTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> PublishTime
		{
			get
			{
				return this._PublishTime;
			}
			set
			{
				if ((this._PublishTime != value))
				{
					this.OnPublishTimeChanging(value);
					this.SendPropertyChanging();
					this._PublishTime = value;
					this.SendPropertyChanged("PublishTime");
					this.OnPublishTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Picture1", DbType="NVarChar(50)")]
		public string Picture1
		{
			get
			{
				return this._Picture1;
			}
			set
			{
				if ((this._Picture1 != value))
				{
					this.OnPicture1Changing(value);
					this.SendPropertyChanging();
					this._Picture1 = value;
					this.SendPropertyChanged("Picture1");
					this.OnPicture1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Picture2", DbType="NVarChar(50)")]
		public string Picture2
		{
			get
			{
				return this._Picture2;
			}
			set
			{
				if ((this._Picture2 != value))
				{
					this.OnPicture2Changing(value);
					this.SendPropertyChanging();
					this._Picture2 = value;
					this.SendPropertyChanged("Picture2");
					this.OnPicture2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Picture3", DbType="NVarChar(50)")]
		public string Picture3
		{
			get
			{
				return this._Picture3;
			}
			set
			{
				if ((this._Picture3 != value))
				{
					this.OnPicture3Changing(value);
					this.SendPropertyChanging();
					this._Picture3 = value;
					this.SendPropertyChanged("Picture3");
					this.OnPicture3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Coupon", DbType="Int")]
		public System.Nullable<int> Coupon
		{
			get
			{
				return this._Coupon;
			}
			set
			{
				if ((this._Coupon != value))
				{
					this.OnCouponChanging(value);
					this.SendPropertyChanging();
					this._Coupon = value;
					this.SendPropertyChanged("Coupon");
					this.OnCouponChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookType", DbType="NVarChar(50)")]
		public string BookType
		{
			get
			{
				return this._BookType;
			}
			set
			{
				if ((this._BookType != value))
				{
					this.OnBookTypeChanging(value);
					this.SendPropertyChanging();
					this._BookType = value;
					this.SendPropertyChanged("BookType");
					this.OnBookTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookPrice", DbType="Float")]
		public System.Nullable<double> BookPrice
		{
			get
			{
				return this._BookPrice;
			}
			set
			{
				if ((this._BookPrice != value))
				{
					this.OnBookPriceChanging(value);
					this.SendPropertyChanging();
					this._BookPrice = value;
					this.SendPropertyChanged("BookPrice");
					this.OnBookPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CouponDetail", DbType="NVarChar(20)")]
		public string CouponDetail
		{
			get
			{
				return this._CouponDetail;
			}
			set
			{
				if ((this._CouponDetail != value))
				{
					this.OnCouponDetailChanging(value);
					this.SendPropertyChanging();
					this._CouponDetail = value;
					this.SendPropertyChanged("CouponDetail");
					this.OnCouponDetailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_Comment", Storage="_Comment", ThisKey="BookId", OtherKey="BookId")]
		public EntitySet<Comment> Comment
		{
			get
			{
				return this._Comment;
			}
			set
			{
				this._Comment.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_OrderItem", Storage="_OrderItem", ThisKey="BookId", OtherKey="BookId")]
		public EntitySet<OrderItem> OrderItem
		{
			get
			{
				return this._OrderItem;
			}
			set
			{
				this._OrderItem.Assign(value);
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
		
		private void attach_Comment(Comment entity)
		{
			this.SendPropertyChanging();
			entity.Book = this;
		}
		
		private void detach_Comment(Comment entity)
		{
			this.SendPropertyChanging();
			entity.Book = null;
		}
		
		private void attach_OrderItem(OrderItem entity)
		{
			this.SendPropertyChanging();
			entity.Book = this;
		}
		
		private void detach_OrderItem(OrderItem entity)
		{
			this.SendPropertyChanging();
			entity.Book = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BookOrder")]
	public partial class BookOrder : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OrderId;
		
		private System.Nullable<int> _UserId;
		
		private System.Nullable<double> _TotalPrice;
		
		private System.Nullable<int> _Status;
		
		private System.Data.Linq.Binary _createDate;
		
		private EntitySet<OrderItem> _OrderItem;
		
		private EntityRef<Customer> _Customer;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIdChanging(int value);
    partial void OnOrderIdChanged();
    partial void OnUserIdChanging(System.Nullable<int> value);
    partial void OnUserIdChanged();
    partial void OnTotalPriceChanging(System.Nullable<double> value);
    partial void OnTotalPriceChanged();
    partial void OnStatusChanging(System.Nullable<int> value);
    partial void OnStatusChanged();
    partial void OncreateDateChanging(System.Data.Linq.Binary value);
    partial void OncreateDateChanged();
    #endregion
		
		public BookOrder()
		{
			this._OrderItem = new EntitySet<OrderItem>(new Action<OrderItem>(this.attach_OrderItem), new Action<OrderItem>(this.detach_OrderItem));
			this._Customer = default(EntityRef<Customer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public int OrderId
		{
			get
			{
				return this._OrderId;
			}
			set
			{
				if ((this._OrderId != value))
				{
					this.OnOrderIdChanging(value);
					this.SendPropertyChanging();
					this._OrderId = value;
					this.SendPropertyChanged("OrderId");
					this.OnOrderIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<int> UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalPrice", DbType="Float", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<double> TotalPrice
		{
			get
			{
				return this._TotalPrice;
			}
			set
			{
				if ((this._TotalPrice != value))
				{
					this.OnTotalPriceChanging(value);
					this.SendPropertyChanging();
					this._TotalPrice = value;
					this.SendPropertyChanged("TotalPrice");
					this.OnTotalPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Int", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<int> Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_createDate", AutoSync=AutoSync.Always, DbType="rowversion", IsDbGenerated=true, IsVersion=true, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary createDate
		{
			get
			{
				return this._createDate;
			}
			set
			{
				if ((this._createDate != value))
				{
					this.OncreateDateChanging(value);
					this.SendPropertyChanging();
					this._createDate = value;
					this.SendPropertyChanged("createDate");
					this.OncreateDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BookOrder_OrderItem", Storage="_OrderItem", ThisKey="OrderId", OtherKey="OrderId")]
		public EntitySet<OrderItem> OrderItem
		{
			get
			{
				return this._OrderItem;
			}
			set
			{
				this._OrderItem.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_BookOrder", Storage="_Customer", ThisKey="UserId", OtherKey="UserId", IsForeignKey=true)]
		public Customer Customer
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customer previousValue = this._Customer.Entity;
				if (((previousValue != value) 
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.BookOrder.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.BookOrder.Add(this);
						this._UserId = value.UserId;
					}
					else
					{
						this._UserId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Customer");
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
		
		private void attach_OrderItem(OrderItem entity)
		{
			this.SendPropertyChanging();
			entity.BookOrder = this;
		}
		
		private void detach_OrderItem(OrderItem entity)
		{
			this.SendPropertyChanging();
			entity.BookOrder = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Comment")]
	public partial class Comment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CommentId;
		
		private string _Comment1;
		
		private System.Nullable<int> _Score;
		
		private System.Nullable<int> _BookId;
		
		private System.Nullable<int> _UserId;
		
		private System.Data.Linq.Binary _CommentDate;
		
		private EntityRef<Book> _Book;
		
		private EntityRef<Customer> _Customer;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCommentIdChanging(int value);
    partial void OnCommentIdChanged();
    partial void OnComment1Changing(string value);
    partial void OnComment1Changed();
    partial void OnScoreChanging(System.Nullable<int> value);
    partial void OnScoreChanged();
    partial void OnBookIdChanging(System.Nullable<int> value);
    partial void OnBookIdChanged();
    partial void OnUserIdChanging(System.Nullable<int> value);
    partial void OnUserIdChanged();
    partial void OnCommentDateChanging(System.Data.Linq.Binary value);
    partial void OnCommentDateChanged();
    #endregion
		
		public Comment()
		{
			this._Book = default(EntityRef<Book>);
			this._Customer = default(EntityRef<Customer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CommentId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public int CommentId
		{
			get
			{
				return this._CommentId;
			}
			set
			{
				if ((this._CommentId != value))
				{
					this.OnCommentIdChanging(value);
					this.SendPropertyChanging();
					this._CommentId = value;
					this.SendPropertyChanged("CommentId");
					this.OnCommentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Comment", Storage="_Comment1", DbType="VarChar(100)", UpdateCheck=UpdateCheck.Never)]
		public string Comment1
		{
			get
			{
				return this._Comment1;
			}
			set
			{
				if ((this._Comment1 != value))
				{
					this.OnComment1Changing(value);
					this.SendPropertyChanging();
					this._Comment1 = value;
					this.SendPropertyChanged("Comment1");
					this.OnComment1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Score", DbType="Int", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<int> Score
		{
			get
			{
				return this._Score;
			}
			set
			{
				if ((this._Score != value))
				{
					this.OnScoreChanging(value);
					this.SendPropertyChanging();
					this._Score = value;
					this.SendPropertyChanged("Score");
					this.OnScoreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookId", DbType="Int", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<int> BookId
		{
			get
			{
				return this._BookId;
			}
			set
			{
				if ((this._BookId != value))
				{
					if (this._Book.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBookIdChanging(value);
					this.SendPropertyChanging();
					this._BookId = value;
					this.SendPropertyChanged("BookId");
					this.OnBookIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<int> UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CommentDate", AutoSync=AutoSync.Always, DbType="rowversion", IsDbGenerated=true, IsVersion=true, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary CommentDate
		{
			get
			{
				return this._CommentDate;
			}
			set
			{
				if ((this._CommentDate != value))
				{
					this.OnCommentDateChanging(value);
					this.SendPropertyChanging();
					this._CommentDate = value;
					this.SendPropertyChanged("CommentDate");
					this.OnCommentDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_Comment", Storage="_Book", ThisKey="BookId", OtherKey="BookId", IsForeignKey=true)]
		public Book Book
		{
			get
			{
				return this._Book.Entity;
			}
			set
			{
				Book previousValue = this._Book.Entity;
				if (((previousValue != value) 
							|| (this._Book.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Book.Entity = null;
						previousValue.Comment.Remove(this);
					}
					this._Book.Entity = value;
					if ((value != null))
					{
						value.Comment.Add(this);
						this._BookId = value.BookId;
					}
					else
					{
						this._BookId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Book");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Comment", Storage="_Customer", ThisKey="UserId", OtherKey="UserId", IsForeignKey=true)]
		public Customer Customer
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customer previousValue = this._Customer.Entity;
				if (((previousValue != value) 
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.Comment.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.Comment.Add(this);
						this._UserId = value.UserId;
					}
					else
					{
						this._UserId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Customer");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserId;
		
		private string _UserName;
		
		private string _Password;
		
		private string _Member;
		
		private string _Address;
		
		private string _PhoneNumber;
		
		private string _Receiver;
		
		private EntitySet<BookOrder> _BookOrder;
		
		private EntitySet<Comment> _Comment;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnMemberChanging(string value);
    partial void OnMemberChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    partial void OnReceiverChanging(string value);
    partial void OnReceiverChanged();
    #endregion
		
		public Customer()
		{
			this._BookOrder = new EntitySet<BookOrder>(new Action<BookOrder>(this.attach_BookOrder), new Action<BookOrder>(this.detach_BookOrder));
			this._Comment = new EntitySet<Comment>(new Action<Comment>(this.attach_Comment), new Action<Comment>(this.detach_Comment));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(10)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(12)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Member", DbType="VarChar(10)")]
		public string Member
		{
			get
			{
				return this._Member;
			}
			set
			{
				if ((this._Member != value))
				{
					this.OnMemberChanging(value);
					this.SendPropertyChanging();
					this._Member = value;
					this.SendPropertyChanged("Member");
					this.OnMemberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(10)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="VarChar(20)")]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Receiver", DbType="VarChar(20)")]
		public string Receiver
		{
			get
			{
				return this._Receiver;
			}
			set
			{
				if ((this._Receiver != value))
				{
					this.OnReceiverChanging(value);
					this.SendPropertyChanging();
					this._Receiver = value;
					this.SendPropertyChanged("Receiver");
					this.OnReceiverChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_BookOrder", Storage="_BookOrder", ThisKey="UserId", OtherKey="UserId")]
		public EntitySet<BookOrder> BookOrder
		{
			get
			{
				return this._BookOrder;
			}
			set
			{
				this._BookOrder.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Comment", Storage="_Comment", ThisKey="UserId", OtherKey="UserId")]
		public EntitySet<Comment> Comment
		{
			get
			{
				return this._Comment;
			}
			set
			{
				this._Comment.Assign(value);
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
		
		private void attach_BookOrder(BookOrder entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_BookOrder(BookOrder entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
		
		private void attach_Comment(Comment entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_Comment(Comment entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OrderItem")]
	public partial class OrderItem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ItemId;
		
		private int _BookId;
		
		private int _OrderId;
		
		private System.Nullable<int> _quantity;
		
		private EntityRef<Book> _Book;
		
		private EntityRef<BookOrder> _BookOrder;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnItemIdChanging(int value);
    partial void OnItemIdChanged();
    partial void OnBookIdChanging(int value);
    partial void OnBookIdChanged();
    partial void OnOrderIdChanging(int value);
    partial void OnOrderIdChanged();
    partial void OnquantityChanging(System.Nullable<int> value);
    partial void OnquantityChanged();
    #endregion
		
		public OrderItem()
		{
			this._Book = default(EntityRef<Book>);
			this._BookOrder = default(EntityRef<BookOrder>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ItemId
		{
			get
			{
				return this._ItemId;
			}
			set
			{
				if ((this._ItemId != value))
				{
					this.OnItemIdChanging(value);
					this.SendPropertyChanging();
					this._ItemId = value;
					this.SendPropertyChanged("ItemId");
					this.OnItemIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookId", DbType="Int NOT NULL")]
		public int BookId
		{
			get
			{
				return this._BookId;
			}
			set
			{
				if ((this._BookId != value))
				{
					if (this._Book.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBookIdChanging(value);
					this.SendPropertyChanging();
					this._BookId = value;
					this.SendPropertyChanged("BookId");
					this.OnBookIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderId", DbType="Int NOT NULL")]
		public int OrderId
		{
			get
			{
				return this._OrderId;
			}
			set
			{
				if ((this._OrderId != value))
				{
					if (this._BookOrder.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOrderIdChanging(value);
					this.SendPropertyChanging();
					this._OrderId = value;
					this.SendPropertyChanged("OrderId");
					this.OnOrderIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="Int")]
		public System.Nullable<int> quantity
		{
			get
			{
				return this._quantity;
			}
			set
			{
				if ((this._quantity != value))
				{
					this.OnquantityChanging(value);
					this.SendPropertyChanging();
					this._quantity = value;
					this.SendPropertyChanged("quantity");
					this.OnquantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_OrderItem", Storage="_Book", ThisKey="BookId", OtherKey="BookId", IsForeignKey=true)]
		public Book Book
		{
			get
			{
				return this._Book.Entity;
			}
			set
			{
				Book previousValue = this._Book.Entity;
				if (((previousValue != value) 
							|| (this._Book.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Book.Entity = null;
						previousValue.OrderItem.Remove(this);
					}
					this._Book.Entity = value;
					if ((value != null))
					{
						value.OrderItem.Add(this);
						this._BookId = value.BookId;
					}
					else
					{
						this._BookId = default(int);
					}
					this.SendPropertyChanged("Book");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BookOrder_OrderItem", Storage="_BookOrder", ThisKey="OrderId", OtherKey="OrderId", IsForeignKey=true)]
		public BookOrder BookOrder
		{
			get
			{
				return this._BookOrder.Entity;
			}
			set
			{
				BookOrder previousValue = this._BookOrder.Entity;
				if (((previousValue != value) 
							|| (this._BookOrder.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BookOrder.Entity = null;
						previousValue.OrderItem.Remove(this);
					}
					this._BookOrder.Entity = value;
					if ((value != null))
					{
						value.OrderItem.Add(this);
						this._OrderId = value.OrderId;
					}
					else
					{
						this._OrderId = default(int);
					}
					this.SendPropertyChanged("BookOrder");
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
