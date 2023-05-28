using Business.Abstract;
using Business.Concrete;
using Ninject.Modules;
using System.Net.Http;

namespace Business.DependencyResolvers
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<HttpClient>().To<HttpClient>().InSingletonScope();

            Bind<IBookGenreService>().To<BookGenreManager>().InSingletonScope();
            Bind<IBookService>().To<BookManager>().InSingletonScope();
            Bind<ILanguageService>().To<LanguageManager>().InSingletonScope();
            Bind<IMovieGenreService>().To<MovieGenreManager>().InSingletonScope();
            Bind<IMovieService>().To<MovieManager>().InSingletonScope();
            Bind<IOperationClaimService>().To<OperationClaimManager>().InSingletonScope();
            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserOperationClaimService>().To<UserOperationClaimManager>().InSingletonScope();
            Bind<IAccountService>().To<AccountManager>().InSingletonScope();
            Bind<ICartService>().To<CartManager>().InSingletonScope();
            Bind<IBookFavListService>().To<BookFavListManager>().InSingletonScope();
            Bind<IBookWishListService>().To<BookWishListManager>().InSingletonScope();
            Bind<IMovieWishListService>().To<MovieWishListManager>().InSingletonScope();
            Bind<IMovieFavListService>().To<MovieFavListManager>().InSingletonScope();
            Bind<IActorService>().To<ActorManager>().InSingletonScope();
            Bind<IAuthorService>().To<AuthorManager>().InSingletonScope();
            Bind<IDirectorService>().To<DirectorManager>().InSingletonScope();
            Bind<IMovieActorService>().To<MovieActorManager>().InSingletonScope();
            Bind<IMovieGenreListService>().To<MovieGenreListManager>().InSingletonScope();
            Bind<IBookGenreListService>().To<BookGenreListManager>().InSingletonScope();
            Bind<IDirectorService>().To<DirectorManager>().InSingletonScope();
            Bind<IAuthorService>().To<AuthorManager>().InSingletonScope();
            Bind<IActorService>().To<ActorManager>().InSingletonScope();
            Bind<IMovieActorService>().To<MovieActorManager>().InSingletonScope();
            Bind<IMenuContentService>().To<MenuContentManager>().InSingletonScope();
            Bind<IMenuObjectService>().To<MenuObjectManager>().InSingletonScope();
            Bind<IRatingService>().To<RatingManager>().InSingletonScope();
            Bind<IReviewService>().To<ReviewManager>().InSingletonScope();
            Bind<IActivityService>().To<ActivityManager>().InSingletonScope();
            Bind<IPurchaseService>().To<PurchaseManager>().InSingletonScope();
            Bind<IRecommenderService>().To<RecommenderManager>().InSingletonScope();
        }
    }
}
