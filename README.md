# Using Multiple Databases in ASP.NET Core via Entity Framework Core
## https://code-maze.com/aspnetcore-multiple-databases-efcore
<p>In this article, we are going to learn how to add multiple databases in the ASP.NET Core project using Entity Framework Core.</p>
<p>We are going to show you how our <a href="https://code-maze.com/net-core-web-development-part4/" target="_blank" rel="noopener">repository pattern</a> implementation helps us in the process by using abstractions that will hide all the implementation details from the presentation layer. </p>
<p>Since we already have the repository pattern explained in our <a href="https://code-maze.com/net-core-web-development-part4/" target="_blank" rel="noopener">ASP.NET Core Repository Pattern article</a>, we strongly suggest reading it first to learn more about the repository pattern implementation in ASP.NET Core Web API. We will modify the source code from that project and show you the benefits of the implementation of that pattern when adding multiple databases in an ASP.NET Core project. </p>
<p>We are going to divide this article into the following sections:</p>
<ul>
	<li>Using Multiple Databases to Support Migrations</li>
	<li>Registering Contexts for Multiple Databases in ASP.NET Core</li>
	<li>Injecting Multiple Databases in the Repository Pattern</li>
	<li>Testing Data Fetching From Multiple Databases in ASP.NET Core</li>
	<li>Conclusion</li>
</ul>
