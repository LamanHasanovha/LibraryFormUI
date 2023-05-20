using System;

namespace Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string html = @"<html>
                                <body style=""font-family: 'Times New Roman', Times, serif;"">
                                    <h1 style=""text-align: center;"">Invoice : {InvoiceId}</h1>
                                    <hr>
                                    <br>
                                    <h2>Account information</h2>
                                    <pre><label style=""margin-left: 30px;"">First name :</label>  {FirstName}<br></pre>
                                    <pre><label style=""margin-left: 30px;"">Last name  :</label>  {LastName} <br></pre>
                                    <pre><label style=""margin-left: 30px;"">Username   :</label>  {Username}<br></pre>
                                    <pre><label style=""margin-left: 30px;"">Email      :</label>  {Email}<br></pre>
                                    <h2>Order information</h2>
                                    <ul>
                                    </ul>
                                    <hr>
                                    <pre><h3>Total price :  {TotalPrice}</h3></pre>
                                    <pre><h3>Date        :  {Date}</h3></pre>
                                    <br><br><br><br>
                                    <h4 style=""text-align: center;"">LemAy Tech</h4>
                                </body>
                            </html>";
            string orderHtml = @"<li>
                                    <pre><label> Product Name :</label>  {ProductName}<br></pre>
                                    <pre><label> Price        :</label>  {Price}<br></pre>
                                    <pre><label> Product type :</label>  {ProductType}<br><pre>
                                </li>";

            System.Console.WriteLine(html.Insert(html.IndexOf("<ul>") + 4, orderHtml).Insert(html.IndexOf("<ul>") + 4, orderHtml));

            System.Console.ReadLine();
        }
    }
}
