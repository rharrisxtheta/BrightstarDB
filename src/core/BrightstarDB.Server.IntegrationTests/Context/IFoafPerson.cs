﻿using System;
using System.Collections.Generic;
using BrightstarDB.EntityFramework;
#if !PORTABLE
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
#endif

namespace BrightstarDB.Server.IntegrationTests.Context
{
    [Entity("http://xmlns.com/foaf/0.1/Person")]
#if !PORTABLE
    [ClassAttribute("[DisplayName(\"Person\")]")]
#endif
    public interface IFoafPerson : IFoafAgent
    {
        [Identifier("http://www.networkedplanet.com/people/")]
        string Id { get; }

        [PropertyType("http://xmlns.com/foaf/0.1/nick")]
#if !PORTABLE
        [DisplayName("Also Known As")]
#endif
        string Nickname { get; set; }

#if !PORTABLE
        [PropertyType("http://xmlns.com/foaf/0.1/name")]
        [Required]
        [CustomValidation(typeof(MyCustomValidator), "ValidateName", ErrorMessage="Custom error message")]
        string Name { get; set; }
#else
        [PropertyType("http://xmlns.com/foaf/0.1/name")]
        string Name { get; set; }
#endif

        [PropertyType("http://xmlns.com/foaf/0.1/Organization")]
        string Organisation { get; set; }

        [PropertyType("http://xmlns.com/foaf/0.1/knows")]
        ICollection<IFoafPerson> Knows { get; set; }

        [InversePropertyType("http://xmlns.com/foaf/0.1/knows")]
        ICollection<IFoafPerson> KnownBy { get; set; }

#if !PORTABLE
        [PropertyType("http://dbpedia.org/ontology/birthDate")]
        [DataType(DataType.Date)]
        DateTime? BirthDate { get; set; }
#else
        [PropertyType("http://dbpedia.org/ontology/birthDate")]
        DateTime? BirthDate { get; set; }
#endif

        [PropertyType("http://xmlns.com/foaf/0.1/homepage")]
        Uri Homepage { get; set; }
    }

    public class MyCustomValidator
    {

    }
}
