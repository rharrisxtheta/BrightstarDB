﻿ 

// -----------------------------------------------------------------------
// <autogenerated>
//    This code was generated from a template.
//
//    Changes to this file may cause incorrect behaviour and will be lost
//    if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using BrightstarDB.Client;
using BrightstarDB.EntityFramework;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BrightstarDB.Server.IntegrationTests.Context 
{
    public partial class MyEntityContext : BrightstarEntityContext {
    	private static readonly EntityMappingStore TypeMappings;
    	
    	static MyEntityContext() 
    	{
    		TypeMappings = new EntityMappingStore();
    		var provider = new ReflectionMappingProvider();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.Server.IntegrationTests.Context.IAnimal));
    		TypeMappings.AddImplMapping<BrightstarDB.Server.IntegrationTests.Context.IAnimal, BrightstarDB.Server.IntegrationTests.Context.Animal>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.Server.IntegrationTests.Context.IDepartment));
    		TypeMappings.AddImplMapping<BrightstarDB.Server.IntegrationTests.Context.IDepartment, BrightstarDB.Server.IntegrationTests.Context.Department>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.Server.IntegrationTests.Context.IFoafAgent));
    		TypeMappings.AddImplMapping<BrightstarDB.Server.IntegrationTests.Context.IFoafAgent, BrightstarDB.Server.IntegrationTests.Context.FoafAgent>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.Server.IntegrationTests.Context.IFoafPerson));
    		TypeMappings.AddImplMapping<BrightstarDB.Server.IntegrationTests.Context.IFoafPerson, BrightstarDB.Server.IntegrationTests.Context.FoafPerson>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.Server.IntegrationTests.Context.IJobRole));
    		TypeMappings.AddImplMapping<BrightstarDB.Server.IntegrationTests.Context.IJobRole, BrightstarDB.Server.IntegrationTests.Context.JobRole>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.Server.IntegrationTests.Context.IPerson));
    		TypeMappings.AddImplMapping<BrightstarDB.Server.IntegrationTests.Context.IPerson, BrightstarDB.Server.IntegrationTests.Context.Person>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.Server.IntegrationTests.Context.ISkill));
    		TypeMappings.AddImplMapping<BrightstarDB.Server.IntegrationTests.Context.ISkill, BrightstarDB.Server.IntegrationTests.Context.Skill>();
    	}
    	
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// Data Object Store connection
    	/// </summary>
    	/// <param name="dataObjectStore">The connection to the Brightstar Data Object Store that will provide the entity objects</param>
    	public MyEntityContext(IDataObjectStore dataObjectStore) : base(TypeMappings, dataObjectStore)
    	{
    		InitializeContext();
    	}
    
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar connection string
    	/// </summary>
    	/// <param name="connectionString">The connection to be used to connect to an existing BrightstarDB store</param>
    	/// <param name="enableOptimisticLocking">OPTIONAL: If set to true optmistic locking will be applied to all entity updates</param>
        /// <param name="updateGraphUri">OPTIONAL: The URI identifier of the graph to be updated with any new triples created by operations on the store. If
        /// not defined, the default graph in the store will be updated.</param>
        /// <param name="datasetGraphUris">OPTIONAL: The URI identifiers of the graphs that will be queried to retrieve entities and their properties.
        /// If not defined, all graphs in the store will be queried.</param>
        /// <param name="versionGraphUri">OPTIONAL: The URI identifier of the graph that contains version number statements for entities. 
        /// If not defined, the <paramref name="updateGraphUri"/> will be used.</param>
    	public MyEntityContext(
    	    string connectionString, 
    		bool? enableOptimisticLocking=null,
    		string updateGraphUri = null,
    		IEnumerable<string> datasetGraphUris = null,
    		string versionGraphUri = null
        ) : base(TypeMappings, connectionString, enableOptimisticLocking, updateGraphUri, datasetGraphUris, versionGraphUri)
    	{
    		InitializeContext();
    	}
    
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// connection string retrieved from the configuration.
    	/// </summary>
    	public MyEntityContext() : base(TypeMappings)
    	{
    		InitializeContext();
    	}
    	
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// connection string retrieved from the configuration and the
    	//  specified target graphs
    	/// </summary>
        /// <param name="updateGraphUri">The URI identifier of the graph to be updated with any new triples created by operations on the store. If
        /// set to null, the default graph in the store will be updated.</param>
        /// <param name="datasetGraphUris">The URI identifiers of the graphs that will be queried to retrieve entities and their properties.
        /// If set to null, all graphs in the store will be queried.</param>
        /// <param name="versionGraphUri">The URI identifier of the graph that contains version number statements for entities. 
        /// If set to null, the value of <paramref name="updateGraphUri"/> will be used.</param>
    	public MyEntityContext(
    		string updateGraphUri,
    		IEnumerable<string> datasetGraphUris,
    		string versionGraphUri
    	) : base(TypeMappings, updateGraphUri:updateGraphUri, datasetGraphUris:datasetGraphUris, versionGraphUri:versionGraphUri)
    	{
    		InitializeContext();
    	}
    	
    	private void InitializeContext() 
    	{
    		Animals = 	new BrightstarEntitySet<BrightstarDB.Server.IntegrationTests.Context.IAnimal>(this);
    		Departments = 	new BrightstarEntitySet<BrightstarDB.Server.IntegrationTests.Context.IDepartment>(this);
    		FoafAgents = 	new BrightstarEntitySet<BrightstarDB.Server.IntegrationTests.Context.IFoafAgent>(this);
    		FoafPersons = 	new BrightstarEntitySet<BrightstarDB.Server.IntegrationTests.Context.IFoafPerson>(this);
    		JobRoles = 	new BrightstarEntitySet<BrightstarDB.Server.IntegrationTests.Context.IJobRole>(this);
    		Persons = 	new BrightstarEntitySet<BrightstarDB.Server.IntegrationTests.Context.IPerson>(this);
    		Skills = 	new BrightstarEntitySet<BrightstarDB.Server.IntegrationTests.Context.ISkill>(this);
    	}
    	
    	public IEntitySet<BrightstarDB.Server.IntegrationTests.Context.IAnimal> Animals
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BrightstarDB.Server.IntegrationTests.Context.IDepartment> Departments
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BrightstarDB.Server.IntegrationTests.Context.IFoafAgent> FoafAgents
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BrightstarDB.Server.IntegrationTests.Context.IFoafPerson> FoafPersons
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BrightstarDB.Server.IntegrationTests.Context.IJobRole> JobRoles
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BrightstarDB.Server.IntegrationTests.Context.IPerson> Persons
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BrightstarDB.Server.IntegrationTests.Context.ISkill> Skills
    	{
    		get; private set;
    	}
    	
    }
}
namespace BrightstarDB.Server.IntegrationTests.Context 
{
    
    public partial class Animal : BrightstarEntityObject, IAnimal 
    {
    	public Animal(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Animal() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.Server.IntegrationTests.Context.IAnimal
    
    	public System.String Name
    	{
            		get { return GetRelatedProperty<System.String>("Name"); }
            		set { SetRelatedProperty("Name", value); }
    	}
    
    	public BrightstarDB.Server.IntegrationTests.Context.IPerson Owner
    	{
            get { return GetRelatedObject<BrightstarDB.Server.IntegrationTests.Context.IPerson>("Owner"); }
            set { SetRelatedObject<BrightstarDB.Server.IntegrationTests.Context.IPerson>("Owner", value); }
    	}
    	#endregion
    }
}
namespace BrightstarDB.Server.IntegrationTests.Context 
{
    
    public partial class Department : BrightstarEntityObject, IDepartment 
    {
    	public Department(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Department() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.Server.IntegrationTests.Context.IDepartment
    
    	public System.String Name
    	{
            		get { return GetRelatedProperty<System.String>("Name"); }
            		set { SetRelatedProperty("Name", value); }
    	}
    
    	public System.Int32 DeptId
    	{
            		get { return GetRelatedProperty<System.Int32>("DeptId"); }
            		set { SetRelatedProperty("DeptId", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.Server.IntegrationTests.Context.IPerson> Persons
    	{
    		get { return GetRelatedObjects<BrightstarDB.Server.IntegrationTests.Context.IPerson>("Persons"); }
    		set { SetRelatedObjects("Persons", value); }
    								}
    	#endregion
    }
}
namespace BrightstarDB.Server.IntegrationTests.Context 
{
    
    public partial class FoafAgent : BrightstarEntityObject, IFoafAgent 
    {
    	public FoafAgent(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public FoafAgent() : base() { }
    	#region Implementation of BrightstarDB.Server.IntegrationTests.Context.IFoafAgent
    	public System.Collections.Generic.ICollection<System.String> MboxSums
    	{
    		get { return GetRelatedLiteralPropertiesCollection<System.String>("MboxSums"); }
    		set { SetRelatedLiteralPropertiesCollection<System.String>("MboxSums", value); }
    	}
    	#endregion
    }
}
namespace BrightstarDB.Server.IntegrationTests.Context 
{
    [DisplayName("Person")]
    public partial class FoafPerson : BrightstarEntityObject, IFoafPerson 
    {
    	public FoafPerson(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public FoafPerson() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.Server.IntegrationTests.Context.IFoafPerson
    	
    	[System.ComponentModel.DisplayNameAttribute("Also Known As")]
    	public System.String Nickname
    	{
            		get { return GetRelatedProperty<System.String>("Nickname"); }
            		set { SetRelatedProperty("Nickname", value); }
    	}
    	
    	[System.ComponentModel.DataAnnotations.RequiredAttribute]	
    	[System.ComponentModel.DataAnnotations.CustomValidationAttribute(typeof(MyCustomValidator), "ValidateName", ErrorMessage="Custom error message")]
    	public System.String Name
    	{
            		get { return GetRelatedProperty<System.String>("Name"); }
            		set { SetRelatedProperty("Name", value); }
    	}
    
    	public System.String Organisation
    	{
            		get { return GetRelatedProperty<System.String>("Organisation"); }
            		set { SetRelatedProperty("Organisation", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.Server.IntegrationTests.Context.IFoafPerson> Knows
    	{
    		get { return GetRelatedObjects<BrightstarDB.Server.IntegrationTests.Context.IFoafPerson>("Knows"); }
    		set { SetRelatedObjects("Knows", value); }
    								}
    	public System.Collections.Generic.ICollection<BrightstarDB.Server.IntegrationTests.Context.IFoafPerson> KnownBy
    	{
    		get { return GetRelatedObjects<BrightstarDB.Server.IntegrationTests.Context.IFoafPerson>("KnownBy"); }
    		set { SetRelatedObjects("KnownBy", value); }
    								}
    	
    	[System.ComponentModel.DataAnnotations.DataTypeAttribute(DataType.Date)]
    	public System.Nullable<System.DateTime> BirthDate
    	{
            		get { return GetRelatedProperty<System.Nullable<System.DateTime>>("BirthDate"); }
            		set { SetRelatedProperty("BirthDate", value); }
    	}
    
    	public System.Uri Homepage
    	{
            		get { return GetRelatedProperty<System.Uri>("Homepage"); }
            		set { SetRelatedProperty("Homepage", value); }
    	}
    	#endregion
    	#region Implementation of BrightstarDB.Server.IntegrationTests.Context.IFoafAgent
    	public System.Collections.Generic.ICollection<System.String> MboxSums
    	{
    		get { return GetRelatedLiteralPropertiesCollection<System.String>("MboxSums"); }
    		set { SetRelatedLiteralPropertiesCollection<System.String>("MboxSums", value); }
    	}
    	#endregion
    }
}
namespace BrightstarDB.Server.IntegrationTests.Context 
{
    
    public partial class JobRole : BrightstarEntityObject, IJobRole 
    {
    	public JobRole(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public JobRole() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.Server.IntegrationTests.Context.IJobRole
    
    	public System.String Description
    	{
            		get { return GetRelatedProperty<System.String>("Description"); }
            		set { SetRelatedProperty("Description", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.Server.IntegrationTests.Context.IPerson> Persons
    	{
    		get { return GetRelatedObjects<BrightstarDB.Server.IntegrationTests.Context.IPerson>("Persons"); }
    		set { SetRelatedObjects("Persons", value); }
    								}
    	#endregion
    }
}
namespace BrightstarDB.Server.IntegrationTests.Context 
{
    
    public partial class Person : BrightstarEntityObject, IPerson 
    {
    	public Person(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Person() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.Server.IntegrationTests.Context.IPerson
    
    	public System.String Name
    	{
            		get { return GetRelatedProperty<System.String>("Name"); }
            		set { SetRelatedProperty("Name", value); }
    	}
    
    	public System.Nullable<System.DateTime> DateOfBirth
    	{
            		get { return GetRelatedProperty<System.Nullable<System.DateTime>>("DateOfBirth"); }
            		set { SetRelatedProperty("DateOfBirth", value); }
    	}
    
    	public System.Int32 Age
    	{
            		get { return GetRelatedProperty<System.Int32>("Age"); }
            		set { SetRelatedProperty("Age", value); }
    	}
    
    	public System.Int32 Salary
    	{
            		get { return GetRelatedProperty<System.Int32>("Salary"); }
            		set { SetRelatedProperty("Salary", value); }
    	}
    
    	public BrightstarDB.Server.IntegrationTests.Context.IPerson Mother
    	{
            get { return GetRelatedObject<BrightstarDB.Server.IntegrationTests.Context.IPerson>("Mother"); }
            set { SetRelatedObject<BrightstarDB.Server.IntegrationTests.Context.IPerson>("Mother", value); }
    	}
    
    	public BrightstarDB.Server.IntegrationTests.Context.IPerson Father
    	{
            get { return GetRelatedObject<BrightstarDB.Server.IntegrationTests.Context.IPerson>("Father"); }
            set { SetRelatedObject<BrightstarDB.Server.IntegrationTests.Context.IPerson>("Father", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.Server.IntegrationTests.Context.IPerson> Friends
    	{
    		get { return GetRelatedObjects<BrightstarDB.Server.IntegrationTests.Context.IPerson>("Friends"); }
    		set { SetRelatedObjects("Friends", value); }
    								}
    
    	public BrightstarDB.Server.IntegrationTests.Context.IAnimal Pet
    	{
            get { return GetRelatedObject<BrightstarDB.Server.IntegrationTests.Context.IAnimal>("Pet"); }
            set { SetRelatedObject<BrightstarDB.Server.IntegrationTests.Context.IAnimal>("Pet", value); }
    	}
    
    	public BrightstarDB.Server.IntegrationTests.Context.ISkill MainSkill
    	{
            get { return GetRelatedObject<BrightstarDB.Server.IntegrationTests.Context.ISkill>("MainSkill"); }
            set { SetRelatedObject<BrightstarDB.Server.IntegrationTests.Context.ISkill>("MainSkill", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.Server.IntegrationTests.Context.ISkill> Skills
    	{
    		get { return GetRelatedObjects<BrightstarDB.Server.IntegrationTests.Context.ISkill>("Skills"); }
    		set { SetRelatedObjects("Skills", value); }
    								}
    
    	public BrightstarDB.Server.IntegrationTests.Context.IDepartment Department
    	{
            get { return GetRelatedObject<BrightstarDB.Server.IntegrationTests.Context.IDepartment>("Department"); }
            set { SetRelatedObject<BrightstarDB.Server.IntegrationTests.Context.IDepartment>("Department", value); }
    	}
    
    	public System.Int32 EmployeeId
    	{
            		get { return GetRelatedProperty<System.Int32>("EmployeeId"); }
            		set { SetRelatedProperty("EmployeeId", value); }
    	}
    
    	public BrightstarDB.Server.IntegrationTests.Context.IJobRole JobRole
    	{
            get { return GetRelatedObject<BrightstarDB.Server.IntegrationTests.Context.IJobRole>("JobRole"); }
            set { SetRelatedObject<BrightstarDB.Server.IntegrationTests.Context.IJobRole>("JobRole", value); }
    	}
    	public System.Collections.Generic.ICollection<System.Uri> Websites
    	{
    		get { return GetRelatedLiteralPropertiesCollection<System.Uri>("Websites"); }
    		set { SetRelatedLiteralPropertiesCollection<System.Uri>("Websites", value); }
    	}
    	#endregion
    }
}
namespace BrightstarDB.Server.IntegrationTests.Context 
{
    
    public partial class Skill : BrightstarEntityObject, ISkill 
    {
    	public Skill(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Skill() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.Server.IntegrationTests.Context.ISkill
    
    	public System.String Name
    	{
            		get { return GetRelatedProperty<System.String>("Name"); }
            		set { SetRelatedProperty("Name", value); }
    	}
    
    	public BrightstarDB.Server.IntegrationTests.Context.IPerson Expert
    	{
            get { return GetRelatedObject<BrightstarDB.Server.IntegrationTests.Context.IPerson>("Expert"); }
            set { SetRelatedObject<BrightstarDB.Server.IntegrationTests.Context.IPerson>("Expert", value); }
    	}
    
    	public BrightstarDB.Server.IntegrationTests.Context.ISkill Parent
    	{
            get { return GetRelatedObject<BrightstarDB.Server.IntegrationTests.Context.ISkill>("Parent"); }
            set { SetRelatedObject<BrightstarDB.Server.IntegrationTests.Context.ISkill>("Parent", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.Server.IntegrationTests.Context.ISkill> Children
    	{
    		get { return GetRelatedObjects<BrightstarDB.Server.IntegrationTests.Context.ISkill>("Children"); }
    		set { SetRelatedObjects("Children", value); }
    								}
    	public System.Collections.Generic.ICollection<BrightstarDB.Server.IntegrationTests.Context.IPerson> SkilledPeople
    	{
    		get { return GetRelatedObjects<BrightstarDB.Server.IntegrationTests.Context.IPerson>("SkilledPeople"); }
    		set { SetRelatedObjects("SkilledPeople", value); }
    								}
    	#endregion
    }
}
