using HttpClientCurso.Models;

namespace HttpClientCurso.Service.Sessao
{
    public interface ISessaoInterface
    {
        UsuarioModel BuscarSessao();
        void CriarSessao(UsuarioModel usuario);
        void RemoverSessao();
    }
}
