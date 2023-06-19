﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1378
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqInAction.Chapter14
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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="lia")]
	public partial class LinqBooks : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAuthor(Author instance);
    partial void UpdateAuthor(Author instance);
    partial void DeleteAuthor(Author instance);
    partial void InsertBook(Book instance);
    partial void UpdateBook(Book instance);
    partial void DeleteBook(Book instance);
    partial void InsertBookAuthor(BookAuthor instance);
    partial void UpdateBookAuthor(BookAuthor instance);
    partial void DeleteBookAuthor(BookAuthor instance);
    partial void InsertPublisher(Publisher instance);
    partial void UpdatePublisher(Publisher instance);
    partial void DeletePublisher(Publisher instance);
    partial void InsertReview(Review instance);
    partial void UpdateReview(Review instance);
    partial void DeleteReview(Review instance);
    partial void InsertSubject(Subject instance);
    partial void UpdateSubject(Subject instance);
    partial void DeleteSubject(Subject instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		static LinqBooks()
		{
		}
		
		public LinqBooks(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqBooks(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqBooks(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqBooks(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Author> Author
		{
			get
			{
				return this.GetTable<Author>();
			}
		}
		
		public System.Data.Linq.Table<Book> Book
		{
			get
			{
				return this.GetTable<Book>();
			}
		}
		
		public System.Data.Linq.Table<BookAuthor> BookAuthor
		{
			get
			{
				return this.GetTable<BookAuthor>();
			}
		}
		
		public System.Data.Linq.Table<Publisher> Publisher
		{
			get
			{
				return this.GetTable<Publisher>();
			}
		}
		
		public System.Data.Linq.Table<Review> Review
		{
			get
			{
				return this.GetTable<Review>();
			}
		}
		
		public System.Data.Linq.Table<Subject> Subject
		{
			get
			{
				return this.GetTable<Subject>();
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
	
	[Table(Name="dbo.Author")]
	public partial class Author : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ID;
		
		private string _LastName;
		
		private string _FirstName;
		
		private string _WebSite;
		
		private EntitySet<BookAuthor> _BookAuthor;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate();
    partial void OnCreated();
    partial void OnIDChanging(System.Guid value);
    partial void OnIDChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnWebSiteChanging(string value);
    partial void OnWebSiteChanged();
    #endregion
		
		public Author()
		{
			OnCreated();
			this._BookAuthor = new EntitySet<BookAuthor>(new Action<BookAuthor>(this.attach_BookAuthor), new Action<BookAuthor>(this.detach_BookAuthor));
		}
		
		[Column(Storage="_ID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_LastName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[Column(Storage="_FirstName", DbType="VarChar(30)")]
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
		
		[Column(Storage="_WebSite", DbType="VarChar(200)")]
		public string WebSite
		{
			get
			{
				return this._WebSite;
			}
			set
			{
				if ((this._WebSite != value))
				{
					this.OnWebSiteChanging(value);
					this.SendPropertyChanging();
					this._WebSite = value;
					this.SendPropertyChanged("WebSite");
					this.OnWebSiteChanged();
				}
			}
		}
		
		[Association(Name="FK_BookAuthor_Author", Storage="_BookAuthor", OtherKey="Author", DeleteRule="NO ACTION")]
		public EntitySet<BookAuthor> BookAuthor
		{
			get
			{
				return this._BookAuthor;
			}
			set
			{
				this._BookAuthor.Assign(value);
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
		
		private void attach_BookAuthor(BookAuthor entity)
		{
			this.SendPropertyChanging();
			entity.AuthorAuthor = this;
			this.SendPropertyChanged("BookAuthor");
		}
		
		private void detach_BookAuthor(BookAuthor entity)
		{
			this.SendPropertyChanging();
			entity.AuthorAuthor = null;
			this.SendPropertyChanged("BookAuthor");
		}
	}
	
	[Table(Name="dbo.Book")]
	public partial class Book : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ID;
		
		private string _Title;
		
		private System.Guid _Subject;
		
		private System.Guid _Publisher;
		
		private System.Nullable<System.DateTime> _PubDate;
		
		private System.Nullable<decimal> _Price;
		
		private int _PageCount;
		
		private string _Isbn;
		
		private string _Summary;
		
		private string _Notes;
		
		private EntityRef<Publisher> _PublisherPublisher;
		
		private EntityRef<Subject> _SubjectSubject;
		
		private EntitySet<BookAuthor> _BookAuthor;
		
		private EntitySet<Review> _Review;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate();
    partial void OnCreated();
    partial void OnIDChanging(System.Guid value);
    partial void OnIDChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnSubjectChanging(System.Guid value);
    partial void OnSubjectChanged();
    partial void OnPublisherChanging(System.Guid value);
    partial void OnPublisherChanged();
    partial void OnPubDateChanging(System.Nullable<System.DateTime> value);
    partial void OnPubDateChanged();
    partial void OnPriceChanging(System.Nullable<decimal> value);
    partial void OnPriceChanged();
    partial void OnPageCountChanging(int value);
    partial void OnPageCountChanged();
    partial void OnIsbnChanging(string value);
    partial void OnIsbnChanged();
    partial void OnSummaryChanging(string value);
    partial void OnSummaryChanged();
    partial void OnNotesChanging(string value);
    partial void OnNotesChanged();
    #endregion
		
		public Book()
		{
			OnCreated();
			this._PublisherPublisher = default(EntityRef<Publisher>);
			this._SubjectSubject = default(EntityRef<Subject>);
			this._BookAuthor = new EntitySet<BookAuthor>(new Action<BookAuthor>(this.attach_BookAuthor), new Action<BookAuthor>(this.detach_BookAuthor));
			this._Review = new EntitySet<Review>(new Action<Review>(this.attach_Review), new Action<Review>(this.detach_Review));
		}
		
		[Column(Storage="_ID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_Title", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[Column(Storage="_Subject", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Subject
		{
			get
			{
				return this._Subject;
			}
			set
			{
				if ((this._Subject != value))
				{
					if (this._SubjectSubject.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSubjectChanging(value);
					this.SendPropertyChanging();
					this._Subject = value;
					this.SendPropertyChanged("Subject");
					this.OnSubjectChanged();
				}
			}
		}
		
		[Column(Storage="_Publisher", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Publisher
		{
			get
			{
				return this._Publisher;
			}
			set
			{
				if ((this._Publisher != value))
				{
					if (this._PublisherPublisher.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPublisherChanging(value);
					this.SendPropertyChanging();
					this._Publisher = value;
					this.SendPropertyChanged("Publisher");
					this.OnPublisherChanged();
				}
			}
		}
		
		[Column(Storage="_PubDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> PubDate
		{
			get
			{
				return this._PubDate;
			}
			set
			{
				if ((this._PubDate != value))
				{
					this.OnPubDateChanging(value);
					this.SendPropertyChanging();
					this._PubDate = value;
					this.SendPropertyChanged("PubDate");
					this.OnPubDateChanged();
				}
			}
		}
		
		[Column(Storage="_Price", DbType="Money")]
		public System.Nullable<decimal> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[Column(Storage="_PageCount", DbType="Int NOT NULL")]
		public int PageCount
		{
			get
			{
				return this._PageCount;
			}
			set
			{
				if ((this._PageCount != value))
				{
					this.OnPageCountChanging(value);
					this.SendPropertyChanging();
					this._PageCount = value;
					this.SendPropertyChanged("PageCount");
					this.OnPageCountChanged();
				}
			}
		}
		
		[Column(Storage="_Isbn", DbType="NChar(13)")]
		public string Isbn
		{
			get
			{
				return this._Isbn;
			}
			set
			{
				if ((this._Isbn != value))
				{
					this.OnIsbnChanging(value);
					this.SendPropertyChanging();
					this._Isbn = value;
					this.SendPropertyChanged("Isbn");
					this.OnIsbnChanged();
				}
			}
		}
		
		[Column(Storage="_Summary", DbType="VarChar(2000)")]
		public string Summary
		{
			get
			{
				return this._Summary;
			}
			set
			{
				if ((this._Summary != value))
				{
					this.OnSummaryChanging(value);
					this.SendPropertyChanging();
					this._Summary = value;
					this.SendPropertyChanged("Summary");
					this.OnSummaryChanged();
				}
			}
		}
		
		[Column(Storage="_Notes", DbType="VarChar(2000)")]
		public string Notes
		{
			get
			{
				return this._Notes;
			}
			set
			{
				if ((this._Notes != value))
				{
					this.OnNotesChanging(value);
					this.SendPropertyChanging();
					this._Notes = value;
					this.SendPropertyChanged("Notes");
					this.OnNotesChanged();
				}
			}
		}
		
		[Association(Name="FK_Book_Publisher", Storage="_PublisherPublisher", ThisKey="Publisher", IsForeignKey=true)]
		public Publisher PublisherPublisher
		{
			get
			{
				return this._PublisherPublisher.Entity;
			}
			set
			{
				Publisher previousValue = this._PublisherPublisher.Entity;
				if (((previousValue != value) 
							|| (this._PublisherPublisher.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PublisherPublisher.Entity = null;
						previousValue.Book.Remove(this);
					}
					this._PublisherPublisher.Entity = value;
					if ((value != null))
					{
						value.Book.Add(this);
						this._Publisher = value.ID;
					}
					else
					{
						this._Publisher = default(System.Guid);
					}
					this.SendPropertyChanged("PublisherPublisher");
				}
			}
		}
		
		[Association(Name="FK_Book_Subject", Storage="_SubjectSubject", ThisKey="Subject", IsForeignKey=true)]
		public Subject SubjectSubject
		{
			get
			{
				return this._SubjectSubject.Entity;
			}
			set
			{
				Subject previousValue = this._SubjectSubject.Entity;
				if (((previousValue != value) 
							|| (this._SubjectSubject.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SubjectSubject.Entity = null;
						previousValue.Book.Remove(this);
					}
					this._SubjectSubject.Entity = value;
					if ((value != null))
					{
						value.Book.Add(this);
						this._Subject = value.ID;
					}
					else
					{
						this._Subject = default(System.Guid);
					}
					this.SendPropertyChanged("SubjectSubject");
				}
			}
		}
		
		[Association(Name="FK_BookAuthor_Book", Storage="_BookAuthor", OtherKey="Book", DeleteRule="NO ACTION")]
		public EntitySet<BookAuthor> BookAuthor
		{
			get
			{
				return this._BookAuthor;
			}
			set
			{
				this._BookAuthor.Assign(value);
			}
		}
		
		[Association(Name="FK_Review_Book", Storage="_Review", OtherKey="Book", DeleteRule="NO ACTION")]
		public EntitySet<Review> Review
		{
			get
			{
				return this._Review;
			}
			set
			{
				this._Review.Assign(value);
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
		
		private void attach_BookAuthor(BookAuthor entity)
		{
			this.SendPropertyChanging();
			entity.BookBook = this;
			this.SendPropertyChanged("BookAuthor");
		}
		
		private void detach_BookAuthor(BookAuthor entity)
		{
			this.SendPropertyChanging();
			entity.BookBook = null;
			this.SendPropertyChanged("BookAuthor");
		}
		
		private void attach_Review(Review entity)
		{
			this.SendPropertyChanging();
			entity.BookBook = this;
			this.SendPropertyChanged("Review");
		}
		
		private void detach_Review(Review entity)
		{
			this.SendPropertyChanging();
			entity.BookBook = null;
			this.SendPropertyChanged("Review");
		}
	}
	
	[Table(Name="dbo.BookAuthor")]
	public partial class BookAuthor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Author;
		
		private System.Guid _Book;
		
		private System.Nullable<int> _AuthorOrder;
		
		private EntityRef<Author> _AuthorAuthor;
		
		private EntityRef<Book> _BookBook;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate();
    partial void OnCreated();
    partial void OnAuthorChanging(System.Guid value);
    partial void OnAuthorChanged();
    partial void OnBookChanging(System.Guid value);
    partial void OnBookChanged();
    partial void OnAuthorOrderChanging(System.Nullable<int> value);
    partial void OnAuthorOrderChanged();
    #endregion
		
		public BookAuthor()
		{
			OnCreated();
			this._AuthorAuthor = default(EntityRef<Author>);
			this._BookBook = default(EntityRef<Book>);
		}
		
		[Column(Storage="_Author", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Author
		{
			get
			{
				return this._Author;
			}
			set
			{
				if ((this._Author != value))
				{
					if (this._AuthorAuthor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAuthorChanging(value);
					this.SendPropertyChanging();
					this._Author = value;
					this.SendPropertyChanged("Author");
					this.OnAuthorChanged();
				}
			}
		}
		
		[Column(Storage="_Book", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Book
		{
			get
			{
				return this._Book;
			}
			set
			{
				if ((this._Book != value))
				{
					if (this._BookBook.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBookChanging(value);
					this.SendPropertyChanging();
					this._Book = value;
					this.SendPropertyChanged("Book");
					this.OnBookChanged();
				}
			}
		}
		
		[Column(Storage="_AuthorOrder", DbType="Int")]
		public System.Nullable<int> AuthorOrder
		{
			get
			{
				return this._AuthorOrder;
			}
			set
			{
				if ((this._AuthorOrder != value))
				{
					this.OnAuthorOrderChanging(value);
					this.SendPropertyChanging();
					this._AuthorOrder = value;
					this.SendPropertyChanged("AuthorOrder");
					this.OnAuthorOrderChanged();
				}
			}
		}
		
		[Association(Name="FK_BookAuthor_Author", Storage="_AuthorAuthor", ThisKey="Author", IsForeignKey=true)]
		public Author AuthorAuthor
		{
			get
			{
				return this._AuthorAuthor.Entity;
			}
			set
			{
				Author previousValue = this._AuthorAuthor.Entity;
				if (((previousValue != value) 
							|| (this._AuthorAuthor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._AuthorAuthor.Entity = null;
						previousValue.BookAuthor.Remove(this);
					}
					this._AuthorAuthor.Entity = value;
					if ((value != null))
					{
						value.BookAuthor.Add(this);
						this._Author = value.ID;
					}
					else
					{
						this._Author = default(System.Guid);
					}
					this.SendPropertyChanged("AuthorAuthor");
				}
			}
		}
		
		[Association(Name="FK_BookAuthor_Book", Storage="_BookBook", ThisKey="Book", IsForeignKey=true)]
		public Book BookBook
		{
			get
			{
				return this._BookBook.Entity;
			}
			set
			{
				Book previousValue = this._BookBook.Entity;
				if (((previousValue != value) 
							|| (this._BookBook.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BookBook.Entity = null;
						previousValue.BookAuthor.Remove(this);
					}
					this._BookBook.Entity = value;
					if ((value != null))
					{
						value.BookAuthor.Add(this);
						this._Book = value.ID;
					}
					else
					{
						this._Book = default(System.Guid);
					}
					this.SendPropertyChanged("BookBook");
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
	
	[Table(Name="dbo.Publisher")]
	public partial class Publisher : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ID;
		
		private string _Name;
		
		private System.Data.Linq.Binary _Logo;
		
		private string _WebSite;
		
		private EntitySet<Book> _Book;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate();
    partial void OnCreated();
    partial void OnIDChanging(System.Guid value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnLogoChanging(System.Data.Linq.Binary value);
    partial void OnLogoChanged();
    partial void OnWebSiteChanging(string value);
    partial void OnWebSiteChanged();
    #endregion
		
		public Publisher()
		{
			OnCreated();
			this._Book = new EntitySet<Book>(new Action<Book>(this.attach_Book), new Action<Book>(this.detach_Book));
		}
		
		[Column(Storage="_ID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_Logo", DbType="Image", CanBeNull=true, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Logo
		{
			get
			{
				return this._Logo;
			}
			set
			{
				if ((this._Logo != value))
				{
					this.OnLogoChanging(value);
					this.SendPropertyChanging();
					this._Logo = value;
					this.SendPropertyChanged("Logo");
					this.OnLogoChanged();
				}
			}
		}
		
		[Column(Storage="_WebSite", DbType="VarChar(200)")]
		public string WebSite
		{
			get
			{
				return this._WebSite;
			}
			set
			{
				if ((this._WebSite != value))
				{
					this.OnWebSiteChanging(value);
					this.SendPropertyChanging();
					this._WebSite = value;
					this.SendPropertyChanged("WebSite");
					this.OnWebSiteChanged();
				}
			}
		}
		
		[Association(Name="FK_Book_Publisher", Storage="_Book", OtherKey="Publisher", DeleteRule="NO ACTION")]
		public EntitySet<Book> Book
		{
			get
			{
				return this._Book;
			}
			set
			{
				this._Book.Assign(value);
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
		
		private void attach_Book(Book entity)
		{
			this.SendPropertyChanging();
			entity.PublisherPublisher = this;
			this.SendPropertyChanged("Book");
		}
		
		private void detach_Book(Book entity)
		{
			this.SendPropertyChanging();
			entity.PublisherPublisher = null;
			this.SendPropertyChanged("Book");
		}
	}
	
	[Table(Name="dbo.Review")]
	public partial class Review : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ID;
		
		private System.Guid _Book;
		
		private System.Guid _User;
		
		private System.Nullable<int> _Rating;
		
		private string _Comments;
		
		private EntityRef<Book> _BookBook;
		
		private EntityRef<User> _UserUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate();
    partial void OnCreated();
    partial void OnIDChanging(System.Guid value);
    partial void OnIDChanged();
    partial void OnBookChanging(System.Guid value);
    partial void OnBookChanged();
    partial void OnUserChanging(System.Guid value);
    partial void OnUserChanged();
    partial void OnRatingChanging(System.Nullable<int> value);
    partial void OnRatingChanged();
    partial void OnCommentsChanging(string value);
    partial void OnCommentsChanged();
    #endregion
		
		public Review()
		{
			OnCreated();
			this._BookBook = default(EntityRef<Book>);
			this._UserUser = default(EntityRef<User>);
		}
		
		[Column(Storage="_ID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_Book", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Book
		{
			get
			{
				return this._Book;
			}
			set
			{
				if ((this._Book != value))
				{
					if (this._BookBook.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBookChanging(value);
					this.SendPropertyChanging();
					this._Book = value;
					this.SendPropertyChanged("Book");
					this.OnBookChanged();
				}
			}
		}
		
		[Column(Storage="_User", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid User
		{
			get
			{
				return this._User;
			}
			set
			{
				if ((this._User != value))
				{
					if (this._UserUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserChanging(value);
					this.SendPropertyChanging();
					this._User = value;
					this.SendPropertyChanged("User");
					this.OnUserChanged();
				}
			}
		}
		
		[Column(Storage="_Rating", DbType="Int")]
		public System.Nullable<int> Rating
		{
			get
			{
				return this._Rating;
			}
			set
			{
				if ((this._Rating != value))
				{
					this.OnRatingChanging(value);
					this.SendPropertyChanging();
					this._Rating = value;
					this.SendPropertyChanged("Rating");
					this.OnRatingChanged();
				}
			}
		}
		
		[Column(Storage="_Comments", DbType="VarChar(2000)")]
		public string Comments
		{
			get
			{
				return this._Comments;
			}
			set
			{
				if ((this._Comments != value))
				{
					this.OnCommentsChanging(value);
					this.SendPropertyChanging();
					this._Comments = value;
					this.SendPropertyChanged("Comments");
					this.OnCommentsChanged();
				}
			}
		}
		
		[Association(Name="FK_Review_Book", Storage="_BookBook", ThisKey="Book", IsForeignKey=true)]
		public Book BookBook
		{
			get
			{
				return this._BookBook.Entity;
			}
			set
			{
				Book previousValue = this._BookBook.Entity;
				if (((previousValue != value) 
							|| (this._BookBook.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BookBook.Entity = null;
						previousValue.Review.Remove(this);
					}
					this._BookBook.Entity = value;
					if ((value != null))
					{
						value.Review.Add(this);
						this._Book = value.ID;
					}
					else
					{
						this._Book = default(System.Guid);
					}
					this.SendPropertyChanged("BookBook");
				}
			}
		}
		
		[Association(Name="FK_Review_User", Storage="_UserUser", ThisKey="User", IsForeignKey=true)]
		public User UserUser
		{
			get
			{
				return this._UserUser.Entity;
			}
			set
			{
				User previousValue = this._UserUser.Entity;
				if (((previousValue != value) 
							|| (this._UserUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._UserUser.Entity = null;
						previousValue.Review.Remove(this);
					}
					this._UserUser.Entity = value;
					if ((value != null))
					{
						value.Review.Add(this);
						this._User = value.ID;
					}
					else
					{
						this._User = default(System.Guid);
					}
					this.SendPropertyChanged("UserUser");
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
	
	[Table(Name="dbo.Subject")]
	public partial class Subject : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ID;
		
		private string _Name;
		
		private string _Description;
		
		private EntitySet<Book> _Book;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate();
    partial void OnCreated();
    partial void OnIDChanging(System.Guid value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public Subject()
		{
			OnCreated();
			this._Book = new EntitySet<Book>(new Action<Book>(this.attach_Book), new Action<Book>(this.detach_Book));
		}
		
		[Column(Storage="_ID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_Name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_Description", DbType="VarChar(200)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Association(Name="FK_Book_Subject", Storage="_Book", OtherKey="Subject", DeleteRule="NO ACTION")]
		public EntitySet<Book> Book
		{
			get
			{
				return this._Book;
			}
			set
			{
				this._Book.Assign(value);
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
		
		private void attach_Book(Book entity)
		{
			this.SendPropertyChanging();
			entity.SubjectSubject = this;
			this.SendPropertyChanged("Book");
		}
		
		private void detach_Book(Book entity)
		{
			this.SendPropertyChanging();
			entity.SubjectSubject = null;
			this.SendPropertyChanged("Book");
		}
	}
	
	[Table(Name="dbo.User")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ID;
		
		private string _Name;
		
		private EntitySet<Review> _Review;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate();
    partial void OnCreated();
    partial void OnIDChanging(System.Guid value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public User()
		{
			OnCreated();
			this._Review = new EntitySet<Review>(new Action<Review>(this.attach_Review), new Action<Review>(this.detach_Review));
		}
		
		[Column(Storage="_ID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_Name", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Association(Name="FK_Review_User", Storage="_Review", OtherKey="User", DeleteRule="NO ACTION")]
		public EntitySet<Review> Review
		{
			get
			{
				return this._Review;
			}
			set
			{
				this._Review.Assign(value);
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
		
		private void attach_Review(Review entity)
		{
			this.SendPropertyChanging();
			entity.UserUser = this;
			this.SendPropertyChanged("Review");
		}
		
		private void detach_Review(Review entity)
		{
			this.SendPropertyChanging();
			entity.UserUser = null;
			this.SendPropertyChanged("Review");
		}
	}
}
