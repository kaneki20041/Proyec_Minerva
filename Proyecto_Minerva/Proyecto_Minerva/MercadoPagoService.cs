using MercadoPago.Client.Common;
using MercadoPago.Client.Payment;
using MercadoPago.Config;
using MercadoPago.Resource.Payment;
using MercadoPago;
using MercadoPago.Client.Preference;
using MercadoPago.Resource.Preference;
using System.Diagnostics;
using Proyecto_Minerva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoPago.Client;

namespace CapaPresentacion
{
    public class MercadoPagoService
    {
        private readonly string _accessToken;
        private decimal _lastPreferenceAmount;

        public MercadoPagoService(string accessToken)
        {
            _accessToken = accessToken;
            MercadoPagoConfig.AccessToken = accessToken;
        }

        public async Task<string> CrearPreferencia(decimal monto, string descripcion, string externalReference)
        {
            try
            {
                _lastPreferenceAmount = monto; // Guardamos el monto para la verificación posterior
                var client = new PreferenceClient();

                var preferenceRequest = new PreferenceRequest
                {
                    Items = new List<PreferenceItemRequest>
                {
                    new PreferenceItemRequest
                    {
                        Title = descripcion,
                        Quantity = 1,
                        CurrencyId = "PEN",
                        UnitPrice = monto
                    }
                },
                    ExternalReference = externalReference,
                    BackUrls = new PreferenceBackUrlsRequest
                    {
                        Success = "http://localhost:3000/success",
                        Failure = "http://localhost:3000/failure",
                        Pending = "http://localhost:3000/pending"
                    },
                    AutoReturn = "approved"
                };

                var preference = await client.CreateAsync(preferenceRequest);
                return preference.InitPoint;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al crear preferencia de pago: {ex.Message}");
            }
        }

        public async Task<bool> VerificarPago(string externalReference)
        {
            try
            {
                var client = new PaymentClient();
                var searchRequest = new SearchRequest();

                // Agregamos el filtro para external_reference
                searchRequest.Filters = new Dictionary<string, object>
            {
                {"external_reference", externalReference }
            };

                var searchResponse = await client.SearchAsync(searchRequest);
                var payment = searchResponse.Results.FirstOrDefault();

                if (payment != null)
                {
                    // Verificamos que el estado sea aprobado y que el monto coincida
                    return payment.Status == "approved" &&
                           payment.TransactionAmount == _lastPreferenceAmount;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al verificar el pago: {ex.Message}");
            }
        }
    }
}
