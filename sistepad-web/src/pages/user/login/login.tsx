import "./login.style.css";
import { useEffect, useRef, type ReactElement } from "react";
import { useForm, type SubmitHandler } from "react-hook-form";
import { Link, useNavigate } from "react-router-dom";
import { FormField } from "@/components";
import { emailRegex } from "@/utils/appRegex";
import {
  useAppDispatch,
  type RootState,
} from "@/store/redux/reduxConfiguration";
import { useSelector } from "react-redux";
import { loginAction } from "@/store/user/actions/login";
import { toast } from "react-toastify";
import { resetUserStateAction } from "@/store/user/actions/reset";

type LoginForm = {
  login: string;
  password: string;
};

export function Login(): ReactElement {
  const dispatch = useAppDispatch();
  const navigate = useNavigate();

  const { successLogin, error } = useSelector(
    (state: RootState) => state.user
  );

  const {
    register,
    handleSubmit,
    formState: { errors },
  } = useForm<LoginForm>();

  const onSubmit: SubmitHandler<LoginForm> = (data: LoginForm) => {
    dispatch(
      loginAction({
        Email: data.login,
        Password: data.password,
      })
    );
  };

  useEffect(() => {
    dispatch(resetUserStateAction());
  }, [dispatch]);

  const isFirstRun = useRef(true);
  useEffect(() => {
    if (isFirstRun.current) {
      isFirstRun.current = false;
      return;
    }

    if (successLogin) {
      toast.success("Login realizado com sucesso!");
      navigate("/classes");
    } else if (error && successLogin === false) {
      toast.error(error);
    }
  }, [successLogin, error, navigate]);

  return (
    <div className="login-page">
      <h1 className="app-title">Sisteped</h1>
      <div className="container">
        <div className="form-container">
          <p className="title">Login</p>
          <p className="subtitle">
            Digite seu e-mail e senha para logar no aplicativo
          </p>
          <form className="form" onSubmit={handleSubmit(onSubmit)}>
            <FormField
              required
              label="E-mail:"
              fieldName="login"
              type="text"
              placleholder="email@dominio.com"
              register={register}
              error={!!errors.login}
              errorMessage="E-mail inválido"
              patther={emailRegex}
            />
            <FormField
              required
              label="Senha:"
              fieldName="password"
              type="password"
              placleholder="Digite sua senha"
              register={register}
              error={!!errors.password}
              errorMessage="É obrigatório informar uma senha"
            />
            <div className="subimit-box">
              <input className="subimit-button" type="submit" />
            </div>
            <div className="divider">
              <span>ou</span>
            </div>
          </form>
          <div className="secondary-box">
            <Link className="secondary-button" to="/register">
              Cadastre-se com e-mail
            </Link>
          </div>
          <p className="legal">
            Ao continuar, você concorda com os nossos{" "}
            <a href="#" className="page-links">
              Termos de Serviço
            </a>{" "}
            e{" "}
            <a href="#" className="page-links">
              Política de Privacidade
            </a>
          </p>
        </div>
      </div>
    </div>
  );
}
