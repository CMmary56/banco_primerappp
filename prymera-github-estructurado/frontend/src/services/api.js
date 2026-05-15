const API_URL = 'https://localhost:7080/api'

export async function obtenerProductos() {
  const respuesta = await fetch(`${API_URL}/productos`)
  return respuesta.json()
}

export async function obtenerAgencias() {
  const respuesta = await fetch(`${API_URL}/agencias`)
  return respuesta.json()
}

export async function login(correo, password) {
  const respuesta = await fetch(`${API_URL}/auth/login`, {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify({ correo, password }),
  })

  return respuesta.json()
}
