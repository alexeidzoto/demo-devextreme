/* Options:
Date: 2021-03-30 20:58:04
Version: 5.105
Tip: To override a DTO option, remove "//" prefix before updating
BaseUrl: https://localhost:5001
UsePath: /crud/all/csharp

//GlobalNamespace: 
//MakePartial: False
//MakeVirtual: False
//MakeInternal: False
//MakeDataContractsExtensible: False
//AddReturnMarker: True
//AddDescriptionAsComments: True
//AddDataContractAttributes: False
//AddIndexesToDataMembers: True
//AddGeneratedCodeAttributes: False
//AddResponseStatus: False
//AddImplicitVersion: 
//InitializeCollections: False
//ExportValueTypes: False
//IncludeTypes: 
//ExcludeTypes: 
//AddNamespaces: 
//AddDefaultXmlNamespace: 
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ServiceStack;
using ServiceStack.DataAnnotations;
using Chinook.ServiceModel.Types;
using Chinook.ServiceModel;


namespace Chinook.ServiceModel
{

    [Route("/albums", "POST"), Tag(Tags.Media)]
    public class CreateAlbums
        : IReturn<IdResponse>, IPost, ICreateDb<Albums>
    {
        public string Title { get; set; }
        public long ArtistId { get; set; }
    }

    [Route("/artists", "POST"), Tag(Tags.Media)]
    public class CreateArtists
        : IReturn<IdResponse>, IPost, ICreateDb<Artists>
    {
        public string Name { get; set; }
    }

    [Route("/customers", "POST"), Tag(Tags.Store)]
    public class CreateCustomers
        : IReturn<IdResponse>, IPost, ICreateDb<Customers>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public long? SupportRepId { get; set; }
    }

    [Route("/employees", "POST"), Tag(Tags.Store)]
    public class CreateEmployees
        : IReturn<IdResponse>, IPost, ICreateDb<Employees>
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public long? ReportsTo { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
    }

    [Route("/genres", "POST"), Tag(Tags.Media)]
    public class CreateGenres
        : IReturn<IdResponse>, IPost, ICreateDb<Genres>
    {
        public string Name { get; set; }
    }

    [Route("/invoiceitems", "POST"), Tag(Tags.Store)]
    public class CreateInvoiceItems
        : IReturn<IdResponse>, IPost, ICreateDb<InvoiceItems>
    {
        public long InvoiceId { get; set; }
        public long TrackId { get; set; }
        public decimal UnitPrice { get; set; }
        public long Quantity { get; set; }
    }

    [Route("/invoices", "POST"), Tag(Tags.Store)]
    public class CreateInvoices
        : IReturn<IdResponse>, IPost, ICreateDb<Invoices>
    {
        public long CustomerId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string BillingAddress { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingCountry { get; set; }
        public string BillingPostalCode { get; set; }
        public decimal Total { get; set; }
    }

    [Route("/mediatypes", "POST"), Tag(Tags.Media)]
    public class CreateMediaTypes
        : IReturn<IdResponse>, IPost, ICreateDb<MediaTypes>
    {
        public string Name { get; set; }
    }

    [Route("/playlists", "POST"), Tag(Tags.Media)]
    public class CreatePlaylists
        : IReturn<IdResponse>, IPost, ICreateDb<Playlists>
    {
        public string Name { get; set; }
    }

    [Route("/tracks", "POST"), Tag(Tags.Media)]
    public class CreateTracks
        : IReturn<IdResponse>, IPost, ICreateDb<Tracks>
    {
        public string Name { get; set; }
        public long? AlbumId { get; set; }
        public long MediaTypeId { get; set; }
        public long? GenreId { get; set; }
        public string Composer { get; set; }
        public long Milliseconds { get; set; }
        public long? Bytes { get; set; }
        public decimal UnitPrice { get; set; }
    }

    [Route("/albums/{AlbumId}", "DELETE"), Tag(Tags.Media)]
    public class DeleteAlbums
        : IReturn<IdResponse>, IDelete, IDeleteDb<Albums>
    {
        public long AlbumId { get; set; }
    }

    [Route("/artists/{ArtistId}", "DELETE"), Tag(Tags.Media)]
    public class DeleteArtists
        : IReturn<IdResponse>, IDelete, IDeleteDb<Artists>
    {
        public long ArtistId { get; set; }
    }

    [Route("/customers/{CustomerId}", "DELETE"), Tag(Tags.Store)]
    public class DeleteCustomers
        : IReturn<IdResponse>, IDelete, IDeleteDb<Customers>
    {
        public long CustomerId { get; set; }
    }

    [Route("/employees/{EmployeeId}", "DELETE"), Tag(Tags.Store)]
    public class DeleteEmployees
        : IReturn<IdResponse>, IDelete, IDeleteDb<Employees>
    {
        public long EmployeeId { get; set; }
    }

    [Route("/genres/{GenreId}", "DELETE"), Tag(Tags.Media)]
    public class DeleteGenres
        : IReturn<IdResponse>, IDelete, IDeleteDb<Genres>
    {
        public long GenreId { get; set; }
    }

    [Route("/invoiceitems/{InvoiceLineId}", "DELETE"), Tag(Tags.Store)]
    public class DeleteInvoiceItems
        : IReturn<IdResponse>, IDelete, IDeleteDb<InvoiceItems>
    {
        public long InvoiceLineId { get; set; }
    }

    [Route("/invoices/{InvoiceId}", "DELETE"), Tag(Tags.Store)]
    public class DeleteInvoices
        : IReturn<IdResponse>, IDelete, IDeleteDb<Invoices>
    {
        public long InvoiceId { get; set; }
    }

    [Route("/mediatypes/{MediaTypeId}", "DELETE"), Tag(Tags.Media)]
    public class DeleteMediaTypes
        : IReturn<IdResponse>, IDelete, IDeleteDb<MediaTypes>
    {
        public long MediaTypeId { get; set; }
    }

    [Route("/playlists/{PlaylistId}", "DELETE"), Tag(Tags.Media)]
    public class DeletePlaylists
        : IReturn<IdResponse>, IDelete, IDeleteDb<Playlists>
    {
        public long PlaylistId { get; set; }
    }

    [Route("/tracks/{TrackId}", "DELETE"), Tag(Tags.Media)]
    public class DeleteTracks
        : IReturn<IdResponse>, IDelete, IDeleteDb<Tracks>
    {
        public long TrackId { get; set; }
    }

    [Route("/albums/{AlbumId}", "PATCH"), Tag(Tags.Media)]
    public class PatchAlbums
        : IReturn<IdResponse>, IPatch, IPatchDb<Albums>
    {
        public long AlbumId { get; set; }
        public string Title { get; set; }
        public long ArtistId { get; set; }
    }

    [Route("/artists/{ArtistId}", "PATCH"), Tag(Tags.Media)]
    public class PatchArtists
        : IReturn<IdResponse>, IPatch, IPatchDb<Artists>
    {
        public long ArtistId { get; set; }
        public string Name { get; set; }
    }

    [Route("/customers/{CustomerId}", "PATCH"), Tag(Tags.Store)]
    public class PatchCustomers
        : IReturn<IdResponse>, IPatch, IPatchDb<Customers>
    {
        public long CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public long? SupportRepId { get; set; }
    }

    [Route("/employees/{EmployeeId}", "PATCH"), Tag(Tags.Store)]
    public class PatchEmployees
        : IReturn<IdResponse>, IPatch, IPatchDb<Employees>
    {
        public long EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public long? ReportsTo { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
    }

    [Route("/genres/{GenreId}", "PATCH"), Tag(Tags.Media)]
    public class PatchGenres
        : IReturn<IdResponse>, IPatch, IPatchDb<Genres>
    {
        public long GenreId { get; set; }
        public string Name { get; set; }
    }

    [Route("/invoiceitems/{InvoiceLineId}", "PATCH"), Tag(Tags.Store)]
    public class PatchInvoiceItems
        : IReturn<IdResponse>, IPatch, IPatchDb<InvoiceItems>
    {
        public long InvoiceLineId { get; set; }
        public long InvoiceId { get; set; }
        public long TrackId { get; set; }
        public decimal UnitPrice { get; set; }
        public long Quantity { get; set; }
    }

    [Route("/invoices/{InvoiceId}", "PATCH"), Tag(Tags.Store)]
    public class PatchInvoices
        : IReturn<IdResponse>, IPatch, IPatchDb<Invoices>
    {
        public long InvoiceId { get; set; }
        public long CustomerId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string BillingAddress { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingCountry { get; set; }
        public string BillingPostalCode { get; set; }
        public decimal Total { get; set; }
    }

    [Route("/mediatypes/{MediaTypeId}", "PATCH"), Tag(Tags.Media)]
    public class PatchMediaTypes
        : IReturn<IdResponse>, IPatch, IPatchDb<MediaTypes>
    {
        public long MediaTypeId { get; set; }
        public string Name { get; set; }
    }

    [Route("/playlists/{PlaylistId}", "PATCH"), Tag(Tags.Media)]
    public class PatchPlaylists
        : IReturn<IdResponse>, IPatch, IPatchDb<Playlists>
    {
        public long PlaylistId { get; set; }
        public string Name { get; set; }
    }

    [Route("/tracks/{TrackId}", "PATCH"), Tag(Tags.Media)]
    public class PatchTracks
        : IReturn<IdResponse>, IPatch, IPatchDb<Tracks>
    {
        public long TrackId { get; set; }
        public string Name { get; set; }
        public long? AlbumId { get; set; }
        public long MediaTypeId { get; set; }
        public long? GenreId { get; set; }
        public string Composer { get; set; }
        public long Milliseconds { get; set; }
        public long? Bytes { get; set; }
        public decimal UnitPrice { get; set; }
    }

    [Route("/albums", "GET"), Tag(Tags.AutoQuery), Tag(Tags.Media)]
    [Route("/albums/{AlbumId}", "GET")]
    public class QueryAlbums
        : QueryDb<Albums>, IReturn<QueryResponse<Albums>>, IGet
    {
        public long? AlbumId { get; set; }
    }

    [Route("/artists", "GET"), Tag(Tags.AutoQuery), Tag(Tags.Media)]
    [Route("/artists/{ArtistId}", "GET")]
    public class QueryArtists
        : QueryDb<Artists>, IReturn<QueryResponse<Artists>>, IGet
    {
        public long? ArtistId { get; set; }
        public long[] ArtistIdBetween { get; set; }
        public string NameStartsWith { get; set; }
    }

    [Route("/customers", "GET"), Tag(Tags.AutoQuery), Tag(Tags.Store)]
    [Route("/customers/{CustomerId}", "GET")]
    public class QueryCustomers
        : QueryDb<Customers>, IReturn<QueryResponse<Customers>>, IGet
    {
        public long? CustomerId { get; set; }
    }

    [Route("/employees", "GET"), Tag(Tags.AutoQuery), Tag(Tags.Store)]
    [Route("/employees/{EmployeeId}", "GET")]
    public class QueryEmployees
        : QueryDb<Employees>, IReturn<QueryResponse<Employees>>, IGet
    {
        public long? EmployeeId { get; set; }
    }

    [Route("/genres", "GET"), Tag(Tags.AutoQuery), Tag(Tags.Media)]
    [Route("/genres/{GenreId}", "GET")]
    public class QueryGenres
        : QueryDb<Genres>, IReturn<QueryResponse<Genres>>, IGet
    {
        public long? GenreId { get; set; }
    }

    [Route("/invoiceitems", "GET"), Tag(Tags.AutoQuery), Tag(Tags.Store)]
    [Route("/invoiceitems/{InvoiceLineId}", "GET")]
    public class QueryInvoiceItems
        : QueryDb<InvoiceItems>, IReturn<QueryResponse<InvoiceItems>>, IGet
    {
        public long? InvoiceLineId { get; set; }
    }

    [Route("/invoices", "GET"), Tag(Tags.AutoQuery), Tag(Tags.Store)]
    [Route("/invoices/{InvoiceId}", "GET")]
    public class QueryInvoices
        : QueryDb<Invoices>, IReturn<QueryResponse<Invoices>>, IGet
    {
        public long? InvoiceId { get; set; }
    }

    [Route("/mediatypes", "GET"), Tag(Tags.AutoQuery), Tag(Tags.Media)]
    [Route("/mediatypes/{MediaTypeId}", "GET")]
    public class QueryMediaTypes
        : QueryDb<MediaTypes>, IReturn<QueryResponse<MediaTypes>>, IGet
    {
        public long? MediaTypeId { get; set; }
    }

    [Route("/playlists", "GET"), Tag(Tags.AutoQuery), Tag(Tags.Media)]
    [Route("/playlists/{PlaylistId}", "GET")]
    public class QueryPlaylists
        : QueryDb<Playlists>, IReturn<QueryResponse<Playlists>>, IGet
    {
        public long? PlaylistId { get; set; }
    }

    [Route("/tracks", "GET"), Tag(Tags.AutoQuery), Tag(Tags.Media)]
    [Route("/tracks/{TrackId}", "GET")]
    public class QueryTracks
        : QueryDb<Tracks>, IReturn<QueryResponse<Tracks>>, IGet
    {
        public long? TrackId { get; set; }
        public string NameContains { get; set; }
    }

    [Route("/albums/{AlbumId}", "PUT"), Tag(Tags.Media)]
    public class UpdateAlbums
        : IReturn<IdResponse>, IPut, IUpdateDb<Albums>
    {
        public long AlbumId { get; set; }
        public string Title { get; set; }
        public long ArtistId { get; set; }
    }

    [Route("/artists/{ArtistId}", "PUT"), Tag(Tags.Media)]
    public class UpdateArtists
        : IReturn<IdResponse>, IPut, IUpdateDb<Artists>
    {
        public long ArtistId { get; set; }
        public string Name { get; set; }
    }

    [Route("/customers/{CustomerId}", "PUT"), Tag(Tags.Store)]
    public class UpdateCustomers
        : IReturn<IdResponse>, IPut, IUpdateDb<Customers>
    {
        public long CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public long? SupportRepId { get; set; }
    }

    [Route("/employees/{EmployeeId}", "PUT"), Tag(Tags.Store)]
    public class UpdateEmployees
        : IReturn<IdResponse>, IPut, IUpdateDb<Employees>
    {
        public long EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public long? ReportsTo { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
    }

    [Route("/genres/{GenreId}", "PUT"), Tag(Tags.Media)]
    public class UpdateGenres
        : IReturn<IdResponse>, IPut, IUpdateDb<Genres>
    {
        public long GenreId { get; set; }
        public string Name { get; set; }
    }

    [Route("/invoiceitems/{InvoiceLineId}", "PUT"), Tag(Tags.Store)]
    public class UpdateInvoiceItems
        : IReturn<IdResponse>, IPut, IUpdateDb<InvoiceItems>
    {
        public long InvoiceLineId { get; set; }
        public long InvoiceId { get; set; }
        public long TrackId { get; set; }
        public decimal UnitPrice { get; set; }
        public long Quantity { get; set; }
    }

    [Route("/invoices/{InvoiceId}", "PUT"), Tag(Tags.Store)]
    public class UpdateInvoices
        : IReturn<IdResponse>, IPut, IUpdateDb<Invoices>
    {
        public long InvoiceId { get; set; }
        public long CustomerId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string BillingAddress { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingCountry { get; set; }
        public string BillingPostalCode { get; set; }
        public decimal Total { get; set; }
    }

    [Route("/mediatypes/{MediaTypeId}", "PUT"), Tag(Tags.Media)]
    public class UpdateMediaTypes
        : IReturn<IdResponse>, IPut, IUpdateDb<MediaTypes>
    {
        public long MediaTypeId { get; set; }
        public string Name { get; set; }
    }

    [Route("/playlists/{PlaylistId}", "PUT"), Tag(Tags.Media)]
    public class UpdatePlaylists
        : IReturn<IdResponse>, IPut, IUpdateDb<Playlists>
    {
        public long PlaylistId { get; set; }
        public string Name { get; set; }
    }

    [Route("/tracks/{TrackId}", "PUT"), Tag(Tags.Media)]
    public class UpdateTracks
        : IReturn<IdResponse>, IPut, IUpdateDb<Tracks>
    {
        public long TrackId { get; set; }
        public string Name { get; set; }
        public long? AlbumId { get; set; }
        public long MediaTypeId { get; set; }
        public long? GenreId { get; set; }
        public string Composer { get; set; }
        public long Milliseconds { get; set; }
        public long? Bytes { get; set; }
        public decimal UnitPrice { get; set; }
    }
}

namespace Chinook.ServiceModel.Types
{

    public class Albums
    {
        [AutoIncrement]
        public long AlbumId { get; set; }

        [Required]
        public string Title { get; set; }

        public long ArtistId { get; set; }
    }

    public class Artists
    {
        [AutoIncrement]
        public long ArtistId { get; set; }

        public string Name { get; set; }
    }

    public class Customers
    {
        [AutoIncrement]
        public long CustomerId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Company { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        [Required]
        public string Email { get; set; }

        public long? SupportRepId { get; set; }
    }

    public class Employees
    {
        [AutoIncrement]
        public long EmployeeId { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string Title { get; set; }
        public long? ReportsTo { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
    }

    public class Genres
    {
        [AutoIncrement]
        public long GenreId { get; set; }

        public string Name { get; set; }
    }

    [Alias("invoice_items")]
    public class InvoiceItems
    {
        [AutoIncrement]
        public long InvoiceLineId { get; set; }

        public long InvoiceId { get; set; }
        public long TrackId { get; set; }
        public decimal UnitPrice { get; set; }
        public long Quantity { get; set; }
    }

    public class Invoices
    {
        [AutoIncrement]
        public long InvoiceId { get; set; }

        public long CustomerId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string BillingAddress { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingCountry { get; set; }
        public string BillingPostalCode { get; set; }
        public decimal Total { get; set; }
    }

    [Alias("media_types")]
    public class MediaTypes
    {
        [AutoIncrement]
        public long MediaTypeId { get; set; }

        public string Name { get; set; }
    }

    public class Playlists
    {
        [AutoIncrement]
        public long PlaylistId { get; set; }

        public string Name { get; set; }
    }

    public class Tracks
    {
        [AutoIncrement]
        public long TrackId { get; set; }

        [Required]
        public string Name { get; set; }

        public long? AlbumId { get; set; }
        public long MediaTypeId { get; set; }
        public long? GenreId { get; set; }
        public string Composer { get; set; }
        public long Milliseconds { get; set; }
        public long? Bytes { get; set; }
        public decimal UnitPrice { get; set; }
    }
}

