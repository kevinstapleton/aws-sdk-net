/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the servicecatalog-appregistry-2020-06-24.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AppRegistry.Model;

namespace Amazon.AppRegistry
{
    /// <summary>
    /// Interface for accessing AppRegistry
    ///
    /// AWS Service Catalog AppRegistry enables organizations to understand the application
    /// context of their AWS resources. AppRegistry provides a repository of your applications,
    /// their resources, and the application metadata that you use within your enterprise.
    /// </summary>
    public partial interface IAmazonAppRegistry : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAppRegistryPaginatorFactory Paginators { get; }

        
        #region  AssociateAttributeGroup


        /// <summary>
        /// Associates an attribute group with an application to augment the application's metadata
        /// with the group's attributes. This way applications can be described with user-defined
        /// details which are machine-readable (e.g. for third-party integrations).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAttributeGroup service method.</param>
        /// 
        /// <returns>The response from the AssociateAttributeGroup service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ServiceQuotaExceededException">
        /// The maximum number of resources per account has been reached.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/AssociateAttributeGroup">REST API Reference for AssociateAttributeGroup Operation</seealso>
        AssociateAttributeGroupResponse AssociateAttributeGroup(AssociateAttributeGroupRequest request);



        /// <summary>
        /// Associates an attribute group with an application to augment the application's metadata
        /// with the group's attributes. This way applications can be described with user-defined
        /// details which are machine-readable (e.g. for third-party integrations).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAttributeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateAttributeGroup service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ServiceQuotaExceededException">
        /// The maximum number of resources per account has been reached.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/AssociateAttributeGroup">REST API Reference for AssociateAttributeGroup Operation</seealso>
        Task<AssociateAttributeGroupResponse> AssociateAttributeGroupAsync(AssociateAttributeGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateResource


        /// <summary>
        /// Associates a resource with an application. Both the resource and the application can
        /// be specified either by ID or name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateResource service method.</param>
        /// 
        /// <returns>The response from the AssociateResource service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ServiceQuotaExceededException">
        /// The maximum number of resources per account has been reached.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/AssociateResource">REST API Reference for AssociateResource Operation</seealso>
        AssociateResourceResponse AssociateResource(AssociateResourceRequest request);



        /// <summary>
        /// Associates a resource with an application. Both the resource and the application can
        /// be specified either by ID or name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateResource service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ServiceQuotaExceededException">
        /// The maximum number of resources per account has been reached.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/AssociateResource">REST API Reference for AssociateResource Operation</seealso>
        Task<AssociateResourceResponse> AssociateResourceAsync(AssociateResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateApplication


        /// <summary>
        /// Creates a new application that is the top-level node in a hierarchy of related cloud
        /// resource abstractions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ServiceQuotaExceededException">
        /// The maximum number of resources per account has been reached.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        CreateApplicationResponse CreateApplication(CreateApplicationRequest request);



        /// <summary>
        /// Creates a new application that is the top-level node in a hierarchy of related cloud
        /// resource abstractions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ServiceQuotaExceededException">
        /// The maximum number of resources per account has been reached.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAttributeGroup


        /// <summary>
        /// Creates a new attribute group as a container for user-defined attributes. This approach
        /// enables users to have full control over their cloud application's metadata in a rich
        /// machine-readable format to facilitate integration with automated workflows and third-party
        /// tools.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAttributeGroup service method.</param>
        /// 
        /// <returns>The response from the CreateAttributeGroup service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ServiceQuotaExceededException">
        /// The maximum number of resources per account has been reached.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/CreateAttributeGroup">REST API Reference for CreateAttributeGroup Operation</seealso>
        CreateAttributeGroupResponse CreateAttributeGroup(CreateAttributeGroupRequest request);



        /// <summary>
        /// Creates a new attribute group as a container for user-defined attributes. This approach
        /// enables users to have full control over their cloud application's metadata in a rich
        /// machine-readable format to facilitate integration with automated workflows and third-party
        /// tools.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAttributeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAttributeGroup service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ServiceQuotaExceededException">
        /// The maximum number of resources per account has been reached.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/CreateAttributeGroup">REST API Reference for CreateAttributeGroup Operation</seealso>
        Task<CreateAttributeGroupResponse> CreateAttributeGroupAsync(CreateAttributeGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteApplication


        /// <summary>
        /// Delete an application, specified either by its application ID or name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request);



        /// <summary>
        /// Delete an application, specified either by its application ID or name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAttributeGroup


        /// <summary>
        /// Deletes an attribute group, specified either by its attribute group ID or name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttributeGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteAttributeGroup service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/DeleteAttributeGroup">REST API Reference for DeleteAttributeGroup Operation</seealso>
        DeleteAttributeGroupResponse DeleteAttributeGroup(DeleteAttributeGroupRequest request);



        /// <summary>
        /// Deletes an attribute group, specified either by its attribute group ID or name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttributeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAttributeGroup service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/DeleteAttributeGroup">REST API Reference for DeleteAttributeGroup Operation</seealso>
        Task<DeleteAttributeGroupResponse> DeleteAttributeGroupAsync(DeleteAttributeGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateAttributeGroup


        /// <summary>
        /// Disassociates an attribute group from an application to remove the extra attributes
        /// contained in the attribute group from the application's metadata. This operation reverts
        /// AssociateAttributeGroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAttributeGroup service method.</param>
        /// 
        /// <returns>The response from the DisassociateAttributeGroup service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/DisassociateAttributeGroup">REST API Reference for DisassociateAttributeGroup Operation</seealso>
        DisassociateAttributeGroupResponse DisassociateAttributeGroup(DisassociateAttributeGroupRequest request);



        /// <summary>
        /// Disassociates an attribute group from an application to remove the extra attributes
        /// contained in the attribute group from the application's metadata. This operation reverts
        /// AssociateAttributeGroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAttributeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateAttributeGroup service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/DisassociateAttributeGroup">REST API Reference for DisassociateAttributeGroup Operation</seealso>
        Task<DisassociateAttributeGroupResponse> DisassociateAttributeGroupAsync(DisassociateAttributeGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateResource


        /// <summary>
        /// Disassociates a resource from application. Both the resource and the application can
        /// be specified either by ID or name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResource service method.</param>
        /// 
        /// <returns>The response from the DisassociateResource service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/DisassociateResource">REST API Reference for DisassociateResource Operation</seealso>
        DisassociateResourceResponse DisassociateResource(DisassociateResourceRequest request);



        /// <summary>
        /// Disassociates a resource from application. Both the resource and the application can
        /// be specified either by ID or name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateResource service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/DisassociateResource">REST API Reference for DisassociateResource Operation</seealso>
        Task<DisassociateResourceResponse> DisassociateResourceAsync(DisassociateResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetApplication


        /// <summary>
        /// Retrieves metadata information about one of your applications. The application can
        /// be specified either by its unique ID or by its name (which is unique within one account
        /// in one region at a given point in time). Specify by ID in automated workflows if you
        /// want to make sure that the exact same application is returned or a ResourceNotFoundException
        /// is thrown, avoiding the ABA addressing problem.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/GetApplication">REST API Reference for GetApplication Operation</seealso>
        GetApplicationResponse GetApplication(GetApplicationRequest request);



        /// <summary>
        /// Retrieves metadata information about one of your applications. The application can
        /// be specified either by its unique ID or by its name (which is unique within one account
        /// in one region at a given point in time). Specify by ID in automated workflows if you
        /// want to make sure that the exact same application is returned or a ResourceNotFoundException
        /// is thrown, avoiding the ABA addressing problem.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/GetApplication">REST API Reference for GetApplication Operation</seealso>
        Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAttributeGroup


        /// <summary>
        /// Retrieves an attribute group, either by its name or its ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAttributeGroup service method.</param>
        /// 
        /// <returns>The response from the GetAttributeGroup service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/GetAttributeGroup">REST API Reference for GetAttributeGroup Operation</seealso>
        GetAttributeGroupResponse GetAttributeGroup(GetAttributeGroupRequest request);



        /// <summary>
        /// Retrieves an attribute group, either by its name or its ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAttributeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAttributeGroup service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/GetAttributeGroup">REST API Reference for GetAttributeGroup Operation</seealso>
        Task<GetAttributeGroupResponse> GetAttributeGroupAsync(GetAttributeGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListApplications


        /// <summary>
        /// Retrieves a list of all of your applications. Results are paginated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/ListApplications">REST API Reference for ListApplications Operation</seealso>
        ListApplicationsResponse ListApplications(ListApplicationsRequest request);



        /// <summary>
        /// Retrieves a list of all of your applications. Results are paginated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/ListApplications">REST API Reference for ListApplications Operation</seealso>
        Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAssociatedAttributeGroups


        /// <summary>
        /// Lists all attribute groups that are associated with specified application. Results
        /// are paginated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedAttributeGroups service method.</param>
        /// 
        /// <returns>The response from the ListAssociatedAttributeGroups service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/ListAssociatedAttributeGroups">REST API Reference for ListAssociatedAttributeGroups Operation</seealso>
        ListAssociatedAttributeGroupsResponse ListAssociatedAttributeGroups(ListAssociatedAttributeGroupsRequest request);



        /// <summary>
        /// Lists all attribute groups that are associated with specified application. Results
        /// are paginated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedAttributeGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssociatedAttributeGroups service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/ListAssociatedAttributeGroups">REST API Reference for ListAssociatedAttributeGroups Operation</seealso>
        Task<ListAssociatedAttributeGroupsResponse> ListAssociatedAttributeGroupsAsync(ListAssociatedAttributeGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAssociatedResources


        /// <summary>
        /// Lists all resources that are associated with specified application. Results are paginated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedResources service method.</param>
        /// 
        /// <returns>The response from the ListAssociatedResources service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/ListAssociatedResources">REST API Reference for ListAssociatedResources Operation</seealso>
        ListAssociatedResourcesResponse ListAssociatedResources(ListAssociatedResourcesRequest request);



        /// <summary>
        /// Lists all resources that are associated with specified application. Results are paginated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssociatedResources service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/ListAssociatedResources">REST API Reference for ListAssociatedResources Operation</seealso>
        Task<ListAssociatedResourcesResponse> ListAssociatedResourcesAsync(ListAssociatedResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAttributeGroups


        /// <summary>
        /// Lists all attribute groups which you have access to. Results are paginated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttributeGroups service method.</param>
        /// 
        /// <returns>The response from the ListAttributeGroups service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/ListAttributeGroups">REST API Reference for ListAttributeGroups Operation</seealso>
        ListAttributeGroupsResponse ListAttributeGroups(ListAttributeGroupsRequest request);



        /// <summary>
        /// Lists all attribute groups which you have access to. Results are paginated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttributeGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAttributeGroups service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/ListAttributeGroups">REST API Reference for ListAttributeGroups Operation</seealso>
        Task<ListAttributeGroupsResponse> ListAttributeGroupsAsync(ListAttributeGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateApplication


        /// <summary>
        /// Updates an existing application with new attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request);



        /// <summary>
        /// Updates an existing application with new attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAttributeGroup


        /// <summary>
        /// Updates an existing attribute group with new details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAttributeGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateAttributeGroup service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/UpdateAttributeGroup">REST API Reference for UpdateAttributeGroup Operation</seealso>
        UpdateAttributeGroupResponse UpdateAttributeGroup(UpdateAttributeGroupRequest request);



        /// <summary>
        /// Updates an existing attribute group with new details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAttributeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAttributeGroup service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry/UpdateAttributeGroup">REST API Reference for UpdateAttributeGroup Operation</seealso>
        Task<UpdateAttributeGroupResponse> UpdateAttributeGroupAsync(UpdateAttributeGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}