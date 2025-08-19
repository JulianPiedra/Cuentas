using Models;

namespace CuentasApi
{
    public static class Responses
    {
        public static IResult ConvertToHttpResult(BusinessLogicResponse response)
        {
            if (response.StatusCode == 200 && response.ObjectResponse == null)
            {
                return Results.Json(new { message = response.Message }, statusCode: StatusCodes.Status200OK);
            }


            return response.StatusCode switch
            {
                200 => Results.Json(new { response.ObjectResponse }, statusCode: StatusCodes.Status200OK),
                404 => Results.Json(new { message = response.Message }, statusCode: StatusCodes.Status404NotFound),
                400 => Results.Json(new { message = response.Message }, statusCode: StatusCodes.Status400BadRequest),
                _ => Results.Json(new { message = response.Message }, statusCode: StatusCodes.Status500InternalServerError),
            };


        }
    }
}
