import type { ActionReducerMapBuilder } from "@reduxjs/toolkit";
import type { UserState } from "../state";
import { registerUserAction } from "../actions/register";

export const registerReducers = (builder : ActionReducerMapBuilder<UserState>) =>{
    builder
    .addCase(registerUserAction.pending, (state) => {
        state.loading = true;
        state.error = null;
    })
    .addCase(registerUserAction.fulfilled, (state, action) => {
        state.loading = false;
        state.successRegister = true;
        state.error = null;
    })
    .addCase(registerUserAction.rejected, (state, action) => {
        state.loading = false;
        state.successRegister = false;
        state.error = action.payload as string;
    });
}