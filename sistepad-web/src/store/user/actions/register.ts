import { createAsyncThunk } from "@reduxjs/toolkit";
import { UserService } from "../../../services/userService";
import type { RegisterUserRequestDTO } from "@/data/dtos/user/request/registerUserRequestDTO";

export const registerUserAction = createAsyncThunk<void, RegisterUserRequestDTO, { rejectValue: string }>(
  "user/register",
  async (
    registerUserRequestDTO: RegisterUserRequestDTO,
    thunkAPI
  ) => {
    try {
      await new UserService().createUser(registerUserRequestDTO);
    } catch (error: any) {
      return thunkAPI.rejectWithValue(error?.message ?? "Unknown error");
    }
  }
);